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
    /// <summary>Custom marshaller for Stellar.AllowTrustOp</summary>
    public static class AllowTrustOpGrpcMarshaller
    {
        // Static constructor to configure type
        static AllowTrustOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AllowTrustOp
            if (!model.IsDefined(typeof(Stellar.AllowTrustOp)))
            {
                var metaType = model.Add(typeof(Stellar.AllowTrustOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "trustor");
                metaType.Add(2, "asset");
                metaType.Add(3, "authorize");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AllowTrustOp</summary>
        public static readonly Marshaller<Stellar.AllowTrustOp> AllowTrustOpMarshaller = Marshallers.Create<Stellar.AllowTrustOp>(
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
                        return Serializer.Deserialize<Stellar.AllowTrustOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
