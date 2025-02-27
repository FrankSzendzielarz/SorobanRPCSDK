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
    /// <summary>Custom marshaller for Stellar.AllowTrustResult+AllowTrustLowReserve</summary>
    public static class AllowTrustResultAllowTrustLowReserveGrpcMarshaller
    {
        // Static constructor to configure type
        static AllowTrustResultAllowTrustLowReserveGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AllowTrustResult.AllowTrustLowReserve
            if (!model.IsDefined(typeof(Stellar.AllowTrustResult.AllowTrustLowReserve)))
            {
                var metaType = model.Add(typeof(Stellar.AllowTrustResult.AllowTrustLowReserve), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AllowTrustLowReserve</summary>
        public static readonly Marshaller<Stellar.AllowTrustResult.AllowTrustLowReserve> AllowTrustLowReserveMarshaller = Marshallers.Create<Stellar.AllowTrustResult.AllowTrustLowReserve>(
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
                        return Serializer.Deserialize<Stellar.AllowTrustResult.AllowTrustLowReserve>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
