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
    /// <summary>Custom marshaller for Stellar.SCError+SceCrypto</summary>
    public static class SCErrorSceCryptoGrpcMarshaller
    {
        // Static constructor to configure type
        static SCErrorSceCryptoGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCError.SceCrypto
            if (!model.IsDefined(typeof(Stellar.SCError.SceCrypto)))
            {
                var metaType = model.Add(typeof(Stellar.SCError.SceCrypto), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(6, "code");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SceCrypto</summary>
        public static readonly Marshaller<Stellar.SCError.SceCrypto> SceCryptoMarshaller = Marshallers.Create<Stellar.SCError.SceCrypto>(
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
                        return Serializer.Deserialize<Stellar.SCError.SceCrypto>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
