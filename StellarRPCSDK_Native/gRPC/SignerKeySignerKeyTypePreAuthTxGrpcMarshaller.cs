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
    /// <summary>Custom marshaller for Stellar.SignerKey+SignerKeyTypePreAuthTx</summary>
    public static class SignerKeySignerKeyTypePreAuthTxGrpcMarshaller
    {
        // Static constructor to configure type
        static SignerKeySignerKeyTypePreAuthTxGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignerKey.SignerKeyTypePreAuthTx
            if (!model.IsDefined(typeof(Stellar.SignerKey.SignerKeyTypePreAuthTx)))
            {
                var metaType = model.Add(typeof(Stellar.SignerKey.SignerKeyTypePreAuthTx), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "preAuthTx");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SignerKeyTypePreAuthTx</summary>
        public static readonly Marshaller<Stellar.SignerKey.SignerKeyTypePreAuthTx> SignerKeyTypePreAuthTxMarshaller = Marshallers.Create<Stellar.SignerKey.SignerKeyTypePreAuthTx>(
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
                        return Serializer.Deserialize<Stellar.SignerKey.SignerKeyTypePreAuthTx>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
