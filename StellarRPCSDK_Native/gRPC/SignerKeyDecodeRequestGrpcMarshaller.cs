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
    /// <summary>Custom marshaller for Stellar.SignerKeyDecodeRequest</summary>
    public static class SignerKeyDecodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static SignerKeyDecodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignerKeyDecodeRequest
            if (!model.IsDefined(typeof(Stellar.SignerKeyDecodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.SignerKeyDecodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SignerKeyDecodeRequest</summary>
        public static readonly Marshaller<Stellar.SignerKeyDecodeRequest> SignerKeyDecodeRequestMarshaller = Marshallers.Create<Stellar.SignerKeyDecodeRequest>(
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
                        return Serializer.Deserialize<Stellar.SignerKeyDecodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
