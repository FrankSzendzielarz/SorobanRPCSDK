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
    /// <summary>Custom marshaller for Stellar.SCNonceKey</summary>
    public static class SCNonceKeyGrpcMarshaller
    {
        // Static constructor to configure type
        static SCNonceKeyGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCNonceKey
            if (!model.IsDefined(typeof(Stellar.SCNonceKey)))
            {
                var metaType = model.Add(typeof(Stellar.SCNonceKey), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "nonce");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCNonceKey</summary>
        public static readonly Marshaller<Stellar.SCNonceKey> SCNonceKeyMarshaller = Marshallers.Create<Stellar.SCNonceKey>(
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
                        return Serializer.Deserialize<Stellar.SCNonceKey>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
