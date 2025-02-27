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
    /// <summary>Custom marshaller for Stellar.SetTrustLineFlagsResult+SetTrustLineFlagsLowReserve</summary>
    public static class SetTrustLineFlagsResultSetTrustLineFlagsLowReserveGrpcMarshaller
    {
        // Static constructor to configure type
        static SetTrustLineFlagsResultSetTrustLineFlagsLowReserveGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve
            if (!model.IsDefined(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve)))
            {
                var metaType = model.Add(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SetTrustLineFlagsResult+SetTrustLineFlagsLowReserve</summary>
        public static readonly Marshaller<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve> SetTrustLineFlagsResult_SetTrustLineFlagsLowReserveMarshaller = Marshallers.Create<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve>(
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
                        return Serializer.Deserialize<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
