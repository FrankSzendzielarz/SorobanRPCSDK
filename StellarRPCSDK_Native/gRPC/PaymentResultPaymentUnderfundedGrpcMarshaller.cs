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
    /// <summary>Custom marshaller for Stellar.PaymentResult+PaymentUnderfunded</summary>
    public static class PaymentResultPaymentUnderfundedGrpcMarshaller
    {
        // Static constructor to configure type
        static PaymentResultPaymentUnderfundedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PaymentResult.PaymentUnderfunded
            if (!model.IsDefined(typeof(Stellar.PaymentResult.PaymentUnderfunded)))
            {
                var metaType = model.Add(typeof(Stellar.PaymentResult.PaymentUnderfunded), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PaymentUnderfunded</summary>
        public static readonly Marshaller<Stellar.PaymentResult.PaymentUnderfunded> PaymentUnderfundedMarshaller = Marshallers.Create<Stellar.PaymentResult.PaymentUnderfunded>(
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
                        return Serializer.Deserialize<Stellar.PaymentResult.PaymentUnderfunded>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
