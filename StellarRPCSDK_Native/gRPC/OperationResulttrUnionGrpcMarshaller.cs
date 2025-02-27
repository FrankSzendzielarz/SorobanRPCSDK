// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion</summary>
    public static class OperationResulttrUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.OperationResult.trUnion.CreateAccount));
                metaType.AddSubType(101, typeof(Stellar.OperationResult.trUnion.Payment));
                metaType.AddSubType(102, typeof(Stellar.OperationResult.trUnion.PathPaymentStrictReceive));
                metaType.AddSubType(103, typeof(Stellar.OperationResult.trUnion.ManageSellOffer));
                metaType.AddSubType(104, typeof(Stellar.OperationResult.trUnion.CreatePassiveSellOffer));
                metaType.AddSubType(105, typeof(Stellar.OperationResult.trUnion.SetOptions));
                metaType.AddSubType(106, typeof(Stellar.OperationResult.trUnion.ChangeTrust));
                metaType.AddSubType(107, typeof(Stellar.OperationResult.trUnion.AllowTrust));
                metaType.AddSubType(108, typeof(Stellar.OperationResult.trUnion.AccountMerge));
                metaType.AddSubType(109, typeof(Stellar.OperationResult.trUnion.Inflation));
                metaType.AddSubType(110, typeof(Stellar.OperationResult.trUnion.ManageData));
                metaType.AddSubType(111, typeof(Stellar.OperationResult.trUnion.BumpSequence));
                metaType.AddSubType(112, typeof(Stellar.OperationResult.trUnion.ManageBuyOffer));
                metaType.AddSubType(113, typeof(Stellar.OperationResult.trUnion.PathPaymentStrictSend));
                metaType.AddSubType(114, typeof(Stellar.OperationResult.trUnion.CreateClaimableBalance));
                metaType.AddSubType(115, typeof(Stellar.OperationResult.trUnion.ClaimClaimableBalance));
                metaType.AddSubType(116, typeof(Stellar.OperationResult.trUnion.BeginSponsoringFutureReserves));
                metaType.AddSubType(117, typeof(Stellar.OperationResult.trUnion.EndSponsoringFutureReserves));
                metaType.AddSubType(118, typeof(Stellar.OperationResult.trUnion.RevokeSponsorship));
                metaType.AddSubType(119, typeof(Stellar.OperationResult.trUnion.Clawback));
                metaType.AddSubType(120, typeof(Stellar.OperationResult.trUnion.ClawbackClaimableBalance));
                metaType.AddSubType(121, typeof(Stellar.OperationResult.trUnion.SetTrustLineFlags));
                metaType.AddSubType(122, typeof(Stellar.OperationResult.trUnion.LiquidityPoolDeposit));
                metaType.AddSubType(123, typeof(Stellar.OperationResult.trUnion.LiquidityPoolWithdraw));
                metaType.AddSubType(124, typeof(Stellar.OperationResult.trUnion.InvokeHostFunction));
                metaType.AddSubType(125, typeof(Stellar.OperationResult.trUnion.ExtendFootprintTtl));
                metaType.AddSubType(126, typeof(Stellar.OperationResult.trUnion.RestoreFootprint));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.OperationResult+trUnion</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion> OperationResult_trUnionMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
