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
    /// <summary>Custom marshaller for Stellar.AllowTrustResult+AllowTrustTrustNotRequired</summary>
    public static class AllowTrustResultAllowTrustTrustNotRequiredGrpcMarshaller
    {
        // Static constructor to configure type
        static AllowTrustResultAllowTrustTrustNotRequiredGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AllowTrustResult.AllowTrustTrustNotRequired
            if (!model.IsDefined(typeof(Stellar.AllowTrustResult.AllowTrustTrustNotRequired)))
            {
                var metaType = model.Add(typeof(Stellar.AllowTrustResult.AllowTrustTrustNotRequired), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AllowTrustResult+AllowTrustTrustNotRequired</summary>
        public static readonly Marshaller<Stellar.AllowTrustResult.AllowTrustTrustNotRequired> AllowTrustResult_AllowTrustTrustNotRequiredMarshaller = Marshallers.Create<Stellar.AllowTrustResult.AllowTrustTrustNotRequired>(
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
                        return Serializer.Deserialize<Stellar.AllowTrustResult.AllowTrustTrustNotRequired>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
