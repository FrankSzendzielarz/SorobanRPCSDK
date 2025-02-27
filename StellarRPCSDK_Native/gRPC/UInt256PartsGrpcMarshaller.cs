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
    /// <summary>Custom marshaller for Stellar.UInt256Parts</summary>
    public static class UInt256PartsGrpcMarshaller
    {
        // Static constructor to configure type
        static UInt256PartsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.UInt256Parts
            if (!model.IsDefined(typeof(Stellar.UInt256Parts)))
            {
                var metaType = model.Add(typeof(Stellar.UInt256Parts), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "hi_hi");
                metaType.Add(2, "hi_lo");
                metaType.Add(3, "lo_hi");
                metaType.Add(4, "lo_lo");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for UInt256Parts</summary>
        public static readonly Marshaller<Stellar.UInt256Parts> UInt256PartsMarshaller = Marshallers.Create<Stellar.UInt256Parts>(
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
                        return Serializer.Deserialize<Stellar.UInt256Parts>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
