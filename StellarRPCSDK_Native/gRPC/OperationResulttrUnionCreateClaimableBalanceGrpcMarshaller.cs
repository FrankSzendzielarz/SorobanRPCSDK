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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+CreateClaimableBalance</summary>
    public static class OperationResulttrUnionCreateClaimableBalanceGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionCreateClaimableBalanceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.CreateClaimableBalance
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.CreateClaimableBalance)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.CreateClaimableBalance), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(15, "createClaimableBalanceResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.OperationResult+trUnion+CreateClaimableBalance</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.CreateClaimableBalance> OperationResult_trUnion_CreateClaimableBalanceMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.CreateClaimableBalance>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.CreateClaimableBalance>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
