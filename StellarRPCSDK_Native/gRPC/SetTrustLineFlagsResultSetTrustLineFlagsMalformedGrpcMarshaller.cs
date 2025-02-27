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
    /// <summary>Custom marshaller for Stellar.SetTrustLineFlagsResult+SetTrustLineFlagsMalformed</summary>
    public static class SetTrustLineFlagsResultSetTrustLineFlagsMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static SetTrustLineFlagsResultSetTrustLineFlagsMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsMalformed
            if (!model.IsDefined(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetTrustLineFlagsMalformed</summary>
        public static readonly Marshaller<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsMalformed> SetTrustLineFlagsMalformedMarshaller = Marshallers.Create<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsMalformed>(
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
                        return Serializer.Deserialize<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
