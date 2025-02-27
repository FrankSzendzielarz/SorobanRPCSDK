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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictSendResult+PathPaymentStrictSendNoDestination</summary>
    public static class PathPaymentStrictSendResultPathPaymentStrictSendNoDestinationGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictSendResultPathPaymentStrictSendNoDestinationGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictSendNoDestination</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination> PathPaymentStrictSendNoDestinationMarshaller = Marshallers.Create<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
