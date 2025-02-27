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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictSendResult+PathPaymentStrictSendUnderDestmin</summary>
    public static class PathPaymentStrictSendResultPathPaymentStrictSendUnderDestminGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictSendResultPathPaymentStrictSendUnderDestminGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictSendUnderDestmin</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin> PathPaymentStrictSendUnderDestminMarshaller = Marshallers.Create<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
