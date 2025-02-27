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
    /// <summary>Custom marshaller for Stellar.SignerKey+SignerKeyTypeHashX</summary>
    public static class SignerKeySignerKeyTypeHashXGrpcMarshaller
    {
        // Static constructor to configure type
        static SignerKeySignerKeyTypeHashXGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignerKey.SignerKeyTypeHashX
            if (!model.IsDefined(typeof(Stellar.SignerKey.SignerKeyTypeHashX)))
            {
                var metaType = model.Add(typeof(Stellar.SignerKey.SignerKeyTypeHashX), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "hashX");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SignerKey+SignerKeyTypeHashX</summary>
        public static readonly Marshaller<Stellar.SignerKey.SignerKeyTypeHashX> SignerKey_SignerKeyTypeHashXMarshaller = Marshallers.Create<Stellar.SignerKey.SignerKeyTypeHashX>(
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
                        return Serializer.Deserialize<Stellar.SignerKey.SignerKeyTypeHashX>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
