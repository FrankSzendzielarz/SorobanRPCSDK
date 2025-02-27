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
    /// <summary>Custom marshaller for Stellar.Operation+bodyUnion</summary>
    public static class OperationbodyUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationbodyUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Operation.bodyUnion
            if (!model.IsDefined(typeof(Stellar.Operation.bodyUnion)))
            {
                var metaType = model.Add(typeof(Stellar.Operation.bodyUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.Operation.bodyUnion.CreateAccount));
                metaType.AddSubType(101, typeof(Stellar.Operation.bodyUnion.Payment));
                metaType.AddSubType(102, typeof(Stellar.Operation.bodyUnion.PathPaymentStrictReceive));
                metaType.AddSubType(103, typeof(Stellar.Operation.bodyUnion.ManageSellOffer));
                metaType.AddSubType(104, typeof(Stellar.Operation.bodyUnion.CreatePassiveSellOffer));
                metaType.AddSubType(105, typeof(Stellar.Operation.bodyUnion.SetOptions));
                metaType.AddSubType(106, typeof(Stellar.Operation.bodyUnion.ChangeTrust));
                metaType.AddSubType(107, typeof(Stellar.Operation.bodyUnion.AllowTrust));
                metaType.AddSubType(108, typeof(Stellar.Operation.bodyUnion.AccountMerge));
                metaType.AddSubType(109, typeof(Stellar.Operation.bodyUnion.Inflation));
                metaType.AddSubType(110, typeof(Stellar.Operation.bodyUnion.ManageData));
                metaType.AddSubType(111, typeof(Stellar.Operation.bodyUnion.BumpSequence));
                metaType.AddSubType(112, typeof(Stellar.Operation.bodyUnion.ManageBuyOffer));
                metaType.AddSubType(113, typeof(Stellar.Operation.bodyUnion.PathPaymentStrictSend));
                metaType.AddSubType(114, typeof(Stellar.Operation.bodyUnion.CreateClaimableBalance));
                metaType.AddSubType(115, typeof(Stellar.Operation.bodyUnion.ClaimClaimableBalance));
                metaType.AddSubType(116, typeof(Stellar.Operation.bodyUnion.BeginSponsoringFutureReserves));
                metaType.AddSubType(117, typeof(Stellar.Operation.bodyUnion.EndSponsoringFutureReserves));
                metaType.AddSubType(118, typeof(Stellar.Operation.bodyUnion.RevokeSponsorship));
                metaType.AddSubType(119, typeof(Stellar.Operation.bodyUnion.Clawback));
                metaType.AddSubType(120, typeof(Stellar.Operation.bodyUnion.ClawbackClaimableBalance));
                metaType.AddSubType(121, typeof(Stellar.Operation.bodyUnion.SetTrustLineFlags));
                metaType.AddSubType(122, typeof(Stellar.Operation.bodyUnion.LiquidityPoolDeposit));
                metaType.AddSubType(123, typeof(Stellar.Operation.bodyUnion.LiquidityPoolWithdraw));
                metaType.AddSubType(124, typeof(Stellar.Operation.bodyUnion.InvokeHostFunction));
                metaType.AddSubType(125, typeof(Stellar.Operation.bodyUnion.ExtendFootprintTtl));
                metaType.AddSubType(126, typeof(Stellar.Operation.bodyUnion.RestoreFootprint));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for bodyUnion</summary>
        public static readonly Marshaller<Stellar.Operation.bodyUnion> bodyUnionMarshaller = Marshallers.Create<Stellar.Operation.bodyUnion>(
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
                        return Serializer.Deserialize<Stellar.Operation.bodyUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
