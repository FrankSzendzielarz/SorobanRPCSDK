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
    /// <summary>Custom marshaller for Stellar.ClawbackOp</summary>
    public static class ClawbackOpGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackOp
            if (!model.IsDefined(typeof(Stellar.ClawbackOp)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "asset");
                metaType.Add(2, "from");
                metaType.Add(3, "amount");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClawbackOp</summary>
        public static readonly Marshaller<Stellar.ClawbackOp> ClawbackOpMarshaller = Marshallers.Create<Stellar.ClawbackOp>(
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
                        return Serializer.Deserialize<Stellar.ClawbackOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
