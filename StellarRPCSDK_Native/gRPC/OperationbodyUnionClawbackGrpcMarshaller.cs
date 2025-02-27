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
    /// <summary>Custom marshaller for Stellar.Operation+bodyUnion+Clawback</summary>
    public static class OperationbodyUnionClawbackGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationbodyUnionClawbackGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Operation.bodyUnion.Clawback
            if (!model.IsDefined(typeof(Stellar.Operation.bodyUnion.Clawback)))
            {
                var metaType = model.Add(typeof(Stellar.Operation.bodyUnion.Clawback), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(18, "clawbackOp");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Operation+bodyUnion+Clawback</summary>
        public static readonly Marshaller<Stellar.Operation.bodyUnion.Clawback> Operation_bodyUnion_ClawbackMarshaller = Marshallers.Create<Stellar.Operation.bodyUnion.Clawback>(
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
                        return Serializer.Deserialize<Stellar.Operation.bodyUnion.Clawback>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
