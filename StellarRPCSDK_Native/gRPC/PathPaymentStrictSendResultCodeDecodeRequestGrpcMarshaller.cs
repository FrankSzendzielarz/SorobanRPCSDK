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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictSendResultCodeDecodeRequest</summary>
    public static class PathPaymentStrictSendResultCodeDecodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictSendResultCodeDecodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictSendResultCodeDecodeRequest
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictSendResultCodeDecodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictSendResultCodeDecodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictSendResultCodeDecodeRequest</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictSendResultCodeDecodeRequest> PathPaymentStrictSendResultCodeDecodeRequestMarshaller = Marshallers.Create<Stellar.PathPaymentStrictSendResultCodeDecodeRequest>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictSendResultCodeDecodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
