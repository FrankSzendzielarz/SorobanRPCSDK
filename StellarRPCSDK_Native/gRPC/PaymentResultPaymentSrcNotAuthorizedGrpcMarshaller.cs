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
    /// <summary>Custom marshaller for Stellar.PaymentResult+PaymentSrcNotAuthorized</summary>
    public static class PaymentResultPaymentSrcNotAuthorizedGrpcMarshaller
    {
        // Static constructor to configure type
        static PaymentResultPaymentSrcNotAuthorizedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PaymentResult.PaymentSrcNotAuthorized
            if (!model.IsDefined(typeof(Stellar.PaymentResult.PaymentSrcNotAuthorized)))
            {
                var metaType = model.Add(typeof(Stellar.PaymentResult.PaymentSrcNotAuthorized), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PaymentSrcNotAuthorized</summary>
        public static readonly Marshaller<Stellar.PaymentResult.PaymentSrcNotAuthorized> PaymentSrcNotAuthorizedMarshaller = Marshallers.Create<Stellar.PaymentResult.PaymentSrcNotAuthorized>(
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
                        return Serializer.Deserialize<Stellar.PaymentResult.PaymentSrcNotAuthorized>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
