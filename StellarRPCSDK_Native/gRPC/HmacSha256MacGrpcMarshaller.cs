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
    /// <summary>Custom marshaller for Stellar.HmacSha256Mac</summary>
    public static class HmacSha256MacGrpcMarshaller
    {
        // Static constructor to configure type
        static HmacSha256MacGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HmacSha256Mac
            if (!model.IsDefined(typeof(Stellar.HmacSha256Mac)))
            {
                var metaType = model.Add(typeof(Stellar.HmacSha256Mac), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "mac");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HmacSha256Mac</summary>
        public static readonly Marshaller<Stellar.HmacSha256Mac> HmacSha256MacMarshaller = Marshallers.Create<Stellar.HmacSha256Mac>(
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
                        return Serializer.Deserialize<Stellar.HmacSha256Mac>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
