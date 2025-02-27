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
    /// <summary>Custom marshaller for Stellar.AlphaNum12</summary>
    public static class AlphaNum12GrpcMarshaller
    {
        // Static constructor to configure type
        static AlphaNum12GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AlphaNum12
            if (!model.IsDefined(typeof(Stellar.AlphaNum12)))
            {
                var metaType = model.Add(typeof(Stellar.AlphaNum12), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "assetCode");
                metaType.Add(2, "issuer");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AlphaNum12</summary>
        public static readonly Marshaller<Stellar.AlphaNum12> AlphaNum12Marshaller = Marshallers.Create<Stellar.AlphaNum12>(
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
                        return Serializer.Deserialize<Stellar.AlphaNum12>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
