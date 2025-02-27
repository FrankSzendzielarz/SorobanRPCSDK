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
    /// <summary>Custom marshaller for Stellar.PaymentResult+PaymentNoIssuer</summary>
    public static class PaymentResultPaymentNoIssuerGrpcMarshaller
    {
        // Static constructor to configure type
        static PaymentResultPaymentNoIssuerGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PaymentResult.PaymentNoIssuer
            if (!model.IsDefined(typeof(Stellar.PaymentResult.PaymentNoIssuer)))
            {
                var metaType = model.Add(typeof(Stellar.PaymentResult.PaymentNoIssuer), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PaymentNoIssuer</summary>
        public static readonly Marshaller<Stellar.PaymentResult.PaymentNoIssuer> PaymentNoIssuerMarshaller = Marshallers.Create<Stellar.PaymentResult.PaymentNoIssuer>(
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
                        return Serializer.Deserialize<Stellar.PaymentResult.PaymentNoIssuer>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
