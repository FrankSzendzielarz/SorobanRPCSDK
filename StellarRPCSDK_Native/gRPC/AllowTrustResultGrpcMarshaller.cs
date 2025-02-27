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
    /// <summary>Custom marshaller for Stellar.AllowTrustResult</summary>
    public static class AllowTrustResultGrpcMarshaller
    {
        // Static constructor to configure type
        static AllowTrustResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AllowTrustResult
            if (!model.IsDefined(typeof(Stellar.AllowTrustResult)))
            {
                var metaType = model.Add(typeof(Stellar.AllowTrustResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.AllowTrustResult.AllowTrustSuccess));
                metaType.AddSubType(101, typeof(Stellar.AllowTrustResult.AllowTrustMalformed));
                metaType.AddSubType(102, typeof(Stellar.AllowTrustResult.AllowTrustNoTrustLine));
                metaType.AddSubType(103, typeof(Stellar.AllowTrustResult.AllowTrustTrustNotRequired));
                metaType.AddSubType(104, typeof(Stellar.AllowTrustResult.AllowTrustCantRevoke));
                metaType.AddSubType(105, typeof(Stellar.AllowTrustResult.AllowTrustSelfNotAllowed));
                metaType.AddSubType(106, typeof(Stellar.AllowTrustResult.AllowTrustLowReserve));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AllowTrustResult</summary>
        public static readonly Marshaller<Stellar.AllowTrustResult> AllowTrustResultMarshaller = Marshallers.Create<Stellar.AllowTrustResult>(
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
                        return Serializer.Deserialize<Stellar.AllowTrustResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
