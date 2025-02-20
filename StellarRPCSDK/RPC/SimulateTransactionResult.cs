using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace Stellar.RPC
{
    [ServiceContract]
    public interface ISimulateTransactionResult
    {
      

        Transaction ApplyTo(Transaction original);
    }

    public partial class SimulateTransactionResult : ISimulateTransactionResult
    {


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
