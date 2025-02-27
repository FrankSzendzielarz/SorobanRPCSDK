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
    /// <summary>Custom marshaller for Stellar.PaymentResult+PaymentNoDestination</summary>
    public static class PaymentResultPaymentNoDestinationGrpcMarshaller
    {
        // Static constructor to configure type
        static PaymentResultPaymentNoDestinationGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PaymentResult.PaymentNoDestination
            if (!model.IsDefined(typeof(Stellar.PaymentResult.PaymentNoDestination)))
            {
                var metaType = model.Add(typeof(Stellar.PaymentResult.PaymentNoDestination), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PaymentResult+PaymentNoDestination</summary>
        public static readonly Marshaller<Stellar.PaymentResult.PaymentNoDestination> PaymentResult_PaymentNoDestinationMarshaller = Marshallers.Create<Stellar.PaymentResult.PaymentNoDestination>(
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
                        return Serializer.Deserialize<Stellar.PaymentResult.PaymentNoDestination>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
