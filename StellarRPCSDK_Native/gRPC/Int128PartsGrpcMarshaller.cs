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
    /// <summary>Custom marshaller for Stellar.Int128Parts</summary>
    public static class Int128PartsGrpcMarshaller
    {
        // Static constructor to configure type
        static Int128PartsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Int128Parts
            if (!model.IsDefined(typeof(Stellar.Int128Parts)))
            {
                var metaType = model.Add(typeof(Stellar.Int128Parts), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "hi");
                metaType.Add(2, "lo");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Int128Parts</summary>
        public static readonly Marshaller<Stellar.Int128Parts> Int128PartsMarshaller = Marshallers.Create<Stellar.Int128Parts>(
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
                        return Serializer.Deserialize<Stellar.Int128Parts>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
