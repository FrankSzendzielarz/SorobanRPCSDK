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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictSendResult+PathPaymentStrictSendLineFull</summary>
    public static class PathPaymentStrictSendResultPathPaymentStrictSendLineFullGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictSendResultPathPaymentStrictSendLineFullGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendLineFull
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendLineFull)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendLineFull), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictSendLineFull</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendLineFull> PathPaymentStrictSendLineFullMarshaller = Marshallers.Create<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendLineFull>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendLineFull>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
