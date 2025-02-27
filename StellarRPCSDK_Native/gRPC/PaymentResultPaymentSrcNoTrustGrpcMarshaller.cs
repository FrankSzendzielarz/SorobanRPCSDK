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
    /// <summary>Custom marshaller for Stellar.PaymentResult+PaymentSrcNoTrust</summary>
    public static class PaymentResultPaymentSrcNoTrustGrpcMarshaller
    {
        // Static constructor to configure type
        static PaymentResultPaymentSrcNoTrustGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PaymentResult.PaymentSrcNoTrust
            if (!model.IsDefined(typeof(Stellar.PaymentResult.PaymentSrcNoTrust)))
            {
                var metaType = model.Add(typeof(Stellar.PaymentResult.PaymentSrcNoTrust), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PaymentSrcNoTrust</summary>
        public static readonly Marshaller<Stellar.PaymentResult.PaymentSrcNoTrust> PaymentSrcNoTrustMarshaller = Marshallers.Create<Stellar.PaymentResult.PaymentSrcNoTrust>(
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
                        return Serializer.Deserialize<Stellar.PaymentResult.PaymentSrcNoTrust>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
