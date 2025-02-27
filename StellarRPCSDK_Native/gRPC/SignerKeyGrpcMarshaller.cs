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
    /// <summary>Custom marshaller for Stellar.SignerKey</summary>
    public static class SignerKeyGrpcMarshaller
    {
        // Static constructor to configure type
        static SignerKeyGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignerKey
            if (!model.IsDefined(typeof(Stellar.SignerKey)))
            {
                var metaType = model.Add(typeof(Stellar.SignerKey), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SignerKey.SignerKeyTypeEd25519));
                metaType.AddSubType(101, typeof(Stellar.SignerKey.SignerKeyTypePreAuthTx));
                metaType.AddSubType(102, typeof(Stellar.SignerKey.SignerKeyTypeHashX));
                metaType.AddSubType(103, typeof(Stellar.SignerKey.SignerKeyTypeEd25519SignedPayload));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SignerKey</summary>
        public static readonly Marshaller<Stellar.SignerKey> SignerKeyMarshaller = Marshallers.Create<Stellar.SignerKey>(
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
                        return Serializer.Deserialize<Stellar.SignerKey>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
