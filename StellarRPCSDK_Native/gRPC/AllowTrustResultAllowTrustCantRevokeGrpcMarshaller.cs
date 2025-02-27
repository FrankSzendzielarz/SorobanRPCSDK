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
    /// <summary>Custom marshaller for Stellar.AllowTrustResult+AllowTrustCantRevoke</summary>
    public static class AllowTrustResultAllowTrustCantRevokeGrpcMarshaller
    {
        // Static constructor to configure type
        static AllowTrustResultAllowTrustCantRevokeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AllowTrustResult.AllowTrustCantRevoke
            if (!model.IsDefined(typeof(Stellar.AllowTrustResult.AllowTrustCantRevoke)))
            {
                var metaType = model.Add(typeof(Stellar.AllowTrustResult.AllowTrustCantRevoke), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AllowTrustCantRevoke</summary>
        public static readonly Marshaller<Stellar.AllowTrustResult.AllowTrustCantRevoke> AllowTrustCantRevokeMarshaller = Marshallers.Create<Stellar.AllowTrustResult.AllowTrustCantRevoke>(
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
                        return Serializer.Deserialize<Stellar.AllowTrustResult.AllowTrustCantRevoke>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
