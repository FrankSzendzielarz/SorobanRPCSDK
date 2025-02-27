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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictSendResult+PathPaymentStrictSendNotAuthorized</summary>
    public static class PathPaymentStrictSendResultPathPaymentStrictSendNotAuthorizedGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictSendResultPathPaymentStrictSendNotAuthorizedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PathPaymentStrictSendResult+PathPaymentStrictSendNotAuthorized</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized> PathPaymentStrictSendResult_PathPaymentStrictSendNotAuthorizedMarshaller = Marshallers.Create<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
