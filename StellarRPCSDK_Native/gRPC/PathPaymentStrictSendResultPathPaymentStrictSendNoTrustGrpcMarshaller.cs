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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictSendResult+PathPaymentStrictSendNoTrust</summary>
    public static class PathPaymentStrictSendResultPathPaymentStrictSendNoTrustGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictSendResultPathPaymentStrictSendNoTrustGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PathPaymentStrictSendResult+PathPaymentStrictSendNoTrust</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust> PathPaymentStrictSendResult_PathPaymentStrictSendNoTrustMarshaller = Marshallers.Create<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
