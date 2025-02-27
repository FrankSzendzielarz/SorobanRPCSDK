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
    /// <summary>Custom marshaller for Stellar.AllowTrustResult+AllowTrustMalformed</summary>
    public static class AllowTrustResultAllowTrustMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static AllowTrustResultAllowTrustMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AllowTrustResult.AllowTrustMalformed
            if (!model.IsDefined(typeof(Stellar.AllowTrustResult.AllowTrustMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.AllowTrustResult.AllowTrustMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AllowTrustMalformed</summary>
        public static readonly Marshaller<Stellar.AllowTrustResult.AllowTrustMalformed> AllowTrustMalformedMarshaller = Marshallers.Create<Stellar.AllowTrustResult.AllowTrustMalformed>(
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
                        return Serializer.Deserialize<Stellar.AllowTrustResult.AllowTrustMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
