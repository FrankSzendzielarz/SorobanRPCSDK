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
    /// <summary>Custom marshaller for Stellar.SetTrustLineFlagsResult+SetTrustLineFlagsSuccess</summary>
    public static class SetTrustLineFlagsResultSetTrustLineFlagsSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static SetTrustLineFlagsResultSetTrustLineFlagsSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsSuccess
            if (!model.IsDefined(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetTrustLineFlagsSuccess</summary>
        public static readonly Marshaller<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsSuccess> SetTrustLineFlagsSuccessMarshaller = Marshallers.Create<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsSuccess>(
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
                        return Serializer.Deserialize<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
