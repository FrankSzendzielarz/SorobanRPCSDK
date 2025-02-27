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
    /// <summary>Custom marshaller for Stellar.AllowTrustResult+AllowTrustSuccess</summary>
    public static class AllowTrustResultAllowTrustSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static AllowTrustResultAllowTrustSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AllowTrustResult.AllowTrustSuccess
            if (!model.IsDefined(typeof(Stellar.AllowTrustResult.AllowTrustSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.AllowTrustResult.AllowTrustSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AllowTrustSuccess</summary>
        public static readonly Marshaller<Stellar.AllowTrustResult.AllowTrustSuccess> AllowTrustSuccessMarshaller = Marshallers.Create<Stellar.AllowTrustResult.AllowTrustSuccess>(
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
                        return Serializer.Deserialize<Stellar.AllowTrustResult.AllowTrustSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
