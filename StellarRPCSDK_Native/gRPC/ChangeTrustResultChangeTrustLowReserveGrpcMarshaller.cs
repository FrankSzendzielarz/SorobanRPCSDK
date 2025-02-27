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
    /// <summary>Custom marshaller for Stellar.ChangeTrustResult+ChangeTrustLowReserve</summary>
    public static class ChangeTrustResultChangeTrustLowReserveGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustResultChangeTrustLowReserveGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustResult.ChangeTrustLowReserve
            if (!model.IsDefined(typeof(Stellar.ChangeTrustResult.ChangeTrustLowReserve)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustResult.ChangeTrustLowReserve), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ChangeTrustLowReserve</summary>
        public static readonly Marshaller<Stellar.ChangeTrustResult.ChangeTrustLowReserve> ChangeTrustLowReserveMarshaller = Marshallers.Create<Stellar.ChangeTrustResult.ChangeTrustLowReserve>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustResult.ChangeTrustLowReserve>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
