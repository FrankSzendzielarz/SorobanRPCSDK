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
    /// <summary>Custom marshaller for Stellar.SCError+SceAuth</summary>
    public static class SCErrorSceAuthGrpcMarshaller
    {
        // Static constructor to configure type
        static SCErrorSceAuthGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCError.SceAuth
            if (!model.IsDefined(typeof(Stellar.SCError.SceAuth)))
            {
                var metaType = model.Add(typeof(Stellar.SCError.SceAuth), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(10, "code");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCError+SceAuth</summary>
        public static readonly Marshaller<Stellar.SCError.SceAuth> SCError_SceAuthMarshaller = Marshallers.Create<Stellar.SCError.SceAuth>(
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
                        return Serializer.Deserialize<Stellar.SCError.SceAuth>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
