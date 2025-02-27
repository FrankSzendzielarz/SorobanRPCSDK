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
    /// <summary>Custom marshaller for Stellar.PaymentResult+PaymentNoTrust</summary>
    public static class PaymentResultPaymentNoTrustGrpcMarshaller
    {
        // Static constructor to configure type
        static PaymentResultPaymentNoTrustGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PaymentResult.PaymentNoTrust
            if (!model.IsDefined(typeof(Stellar.PaymentResult.PaymentNoTrust)))
            {
                var metaType = model.Add(typeof(Stellar.PaymentResult.PaymentNoTrust), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PaymentNoTrust</summary>
        public static readonly Marshaller<Stellar.PaymentResult.PaymentNoTrust> PaymentNoTrustMarshaller = Marshallers.Create<Stellar.PaymentResult.PaymentNoTrust>(
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
                        return Serializer.Deserialize<Stellar.PaymentResult.PaymentNoTrust>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
