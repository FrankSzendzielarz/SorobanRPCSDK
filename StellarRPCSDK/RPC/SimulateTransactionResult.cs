using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace Stellar.RPC
{
    [ServiceContract]
    public interface ISimulateTransactionResult_ProtoWrapper
    {
        Transaction ApplyTo(SimulateTransactionResult_ProtoWrapper.ApplyToParam applyTo);
    }


    public class SimulateTransactionResult_ProtoWrapper : ISimulateTransactionResult_ProtoWrapper
    {
        [ProtoContract]
        public class ApplyToParam
        {
            [ProtoMember(1)]
            public SimulateTransactionResult Simulation { get; set; }
            [ProtoMember(2)]
            public Transaction Original { get; set; }

        }

        public Transaction ApplyTo(ApplyToParam applyTo)
        {
            return applyTo.Simulation.ApplyTo(applyTo.Original);
        }
    }

    public partial class SimulateTransactionResult 
    {
        public List<HashIDPreimage.EnvelopeTypeSorobanAuthorization> GetAuthorisationsRequired(uint ledgerExpirationRelativeMax = 1000)
        {
            List<HashIDPreimage.sorobanAuthorizationStruct> authorisations = new List<HashIDPreimage.sorobanAuthorizationStruct>();
            List<SorobanAuthorizationEntry> authEntries = Results.FirstOrDefault()?.SorobanAuthorizations.Where(a=>a.credentials is SorobanCredentials.SorobanCredentialsAddress).ToList();
            if (authEntries!=null)
            {
                var latest = (uint)LatestLedger + ledgerExpirationRelativeMax;
                foreach (var authEntry in authEntries)
                {
                   
                    (authEntry.credentials as SorobanCredentials.SorobanCredentialsAddress).address.signatureExpirationLedger = latest;
                    var authorisationToSign = new HashIDPreimage.sorobanAuthorizationStruct()
                    {
                        invocation=authEntry.rootInvocation,
                        nonce=(authEntry.credentials as SorobanCredentials.SorobanCredentialsAddress).address.nonce,
                        signatureExpirationLedger=latest,
                        networkID = new Hash(Network.Current.NetworkId)
                    };
                    authorisations.Add(authorisationToSign);

                }
            }
            return authorisations.Select(a=>new HashIDPreimage.EnvelopeTypeSorobanAuthorization() { sorobanAuthorization = a }).ToList();
        }

        public bool AddAuthorisationSignature(uint index, byte[] pubkey, byte[] sorobanAuthSig)
        {
            List<SorobanAuthorizationEntry> authEntries = Results.FirstOrDefault()?.SorobanAuthorizations.Where(a => a.credentials is SorobanCredentials.SorobanCredentialsAddress).ToList();
            if (authEntries != null)
            {
                if (authEntries.Count > index)
                {
                    var cred = authEntries[(int)index].credentials as SorobanCredentials.SorobanCredentialsAddress;
                    var sigVector = cred.address.signature as SCVal.ScvVec;
                    if (sigVector == null) sigVector = new SCVal.ScvVec() { vec = new SCVec() { InnerValue = new SCVal.ScvMap[0] } };
                    var sigList = sigVector.vec.InnerValue.ToList();
                    sigList.Add(
                       new SCVal.ScvMap()
                       {
                           map = new SCMapEntry[]
                           {
                                new SCMapEntry() { key=new SCVal.ScvSymbol(){ sym = new SCSymbol("public_key")}, val=new SCVal.ScvBytes(){ bytes= new SCBytes(pubkey) } },
                                new SCMapEntry() { key=new SCVal.ScvSymbol(){ sym = new SCSymbol("signature")}, val=new SCVal.ScvBytes(){ bytes= new SCBytes(sorobanAuthSig) } },
                           }
                       }
                    );
                    sigVector.vec.InnerValue = sigList.ToArray();
                    cred.address.signature = sigVector;
                }
            }
            return false;
        }


        /// <summary>
        /// Modifies the Soroban invocation transaction according
        /// to needs specified by this Simulation. Must be called
        /// before submitting the Soroban transaction after 
        /// successful Simulation.
        /// </summary>
        public Transaction ApplyTo(Transaction original)
        {

            // Clone the transaction to prevent multiple simulations resulting in lost original transaction data, such as the fee
            Transaction transaction = original.Clone();

            // Ensure the transaction is a soroban invocation
            if (transaction == null || !transaction.IsSoroban())
            {
                throw new ArgumentException("Transaction is not a Soroban invocation.");
            }

            // Verify the simulation succeeded
            if (this.Error != null)
            {
                throw new InvalidOperationException("Cannot apply failed simulation to transaction.");
            }

            if (uint.TryParse(MinResourceFee, out var resourceFee))
            {
                transaction.fee += resourceFee;
            }

            transaction.ext = new Transaction.extUnion.case_1() { sorobanData = SorobanTransactionData };

            if (transaction.IsSorobanInvocation())
            {
                Results results = Results.FirstOrDefault();
                if (results != null)
                {
                    (transaction.operations[0].body as Operation.bodyUnion.InvokeHostFunction).invokeHostFunctionOp.auth = results.SorobanAuthorizations.ToArray();
                }

            }

            return transaction;
        }

      

        private SorobanTransactionData _sorobanTransactionData;
        [ProtoMember(100)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public SorobanTransactionData SorobanTransactionData
        {
            get
            {
                if (_sorobanTransactionData == null)
                {
                    if (TransactionData != null)
                    {
                        byte[] bytes = Convert.FromBase64String(TransactionData);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _sorobanTransactionData = SorobanTransactionDataXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _sorobanTransactionData;
            }
        }
        private List<DiagnosticEvent> _events;
        [ProtoMember(101)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public List<DiagnosticEvent> DiagnosticEvents
        {
            get
            {
                if (_events == null)
                {
                    _events = new List<DiagnosticEvent>();
                    if (Events != null)
                    {
                        foreach (var xdr in Events)
                        {
                            byte[] bytes = Convert.FromBase64String(xdr);
                            using (MemoryStream stream = new MemoryStream(bytes))
                            {
                                _events.Add(DiagnosticEventXdr.Decode(new XdrReader(stream)));

                            }
                        }
                    }
                }
                return _events;
            }
        }

    }



}
