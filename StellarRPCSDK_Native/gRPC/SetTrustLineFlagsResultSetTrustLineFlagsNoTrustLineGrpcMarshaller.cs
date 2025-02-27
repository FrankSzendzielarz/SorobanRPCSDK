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
    /// <summary>Custom marshaller for Stellar.SetTrustLineFlagsResult+SetTrustLineFlagsNoTrustLine</summary>
    public static class SetTrustLineFlagsResultSetTrustLineFlagsNoTrustLineGrpcMarshaller
    {
        // Static constructor to configure type
        static SetTrustLineFlagsResultSetTrustLineFlagsNoTrustLineGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine
            if (!model.IsDefined(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine)))
            {
                var metaType = model.Add(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetTrustLineFlagsNoTrustLine</summary>
        public static readonly Marshaller<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine> SetTrustLineFlagsNoTrustLineMarshaller = Marshallers.Create<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine>(
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
                        return Serializer.Deserialize<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
