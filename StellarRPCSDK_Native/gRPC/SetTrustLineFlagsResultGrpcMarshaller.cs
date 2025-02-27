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
    /// <summary>Custom marshaller for Stellar.SetTrustLineFlagsResult</summary>
    public static class SetTrustLineFlagsResultGrpcMarshaller
    {
        // Static constructor to configure type
        static SetTrustLineFlagsResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetTrustLineFlagsResult
            if (!model.IsDefined(typeof(Stellar.SetTrustLineFlagsResult)))
            {
                var metaType = model.Add(typeof(Stellar.SetTrustLineFlagsResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsSuccess));
                metaType.AddSubType(101, typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsMalformed));
                metaType.AddSubType(102, typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine));
                metaType.AddSubType(103, typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsCantRevoke));
                metaType.AddSubType(104, typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState));
                metaType.AddSubType(105, typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetTrustLineFlagsResult</summary>
        public static readonly Marshaller<Stellar.SetTrustLineFlagsResult> SetTrustLineFlagsResultMarshaller = Marshallers.Create<Stellar.SetTrustLineFlagsResult>(
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
                        return Serializer.Deserialize<Stellar.SetTrustLineFlagsResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
