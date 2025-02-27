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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+ClaimClaimableBalance</summary>
    public static class OperationResulttrUnionClaimClaimableBalanceGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionClaimClaimableBalanceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.ClaimClaimableBalance
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.ClaimClaimableBalance)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.ClaimClaimableBalance), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(16, "claimClaimableBalanceResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimClaimableBalance</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.ClaimClaimableBalance> ClaimClaimableBalanceMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.ClaimClaimableBalance>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.ClaimClaimableBalance>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
