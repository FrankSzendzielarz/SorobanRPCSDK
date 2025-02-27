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
    /// <summary>Custom marshaller for Stellar.SetTrustLineFlagsResultCode</summary>
    public static class SetTrustLineFlagsResultCodeGrpcMarshaller
    {
        // Static constructor to configure type
        static SetTrustLineFlagsResultCodeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetTrustLineFlagsResultCode
            if (!model.IsDefined(typeof(Stellar.SetTrustLineFlagsResultCode)))
            {
                var metaType = model.Add(typeof(Stellar.SetTrustLineFlagsResultCode), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetTrustLineFlagsResultCode</summary>
        public static readonly Marshaller<Stellar.SetTrustLineFlagsResultCode> SetTrustLineFlagsResultCodeMarshaller = Marshallers.Create<Stellar.SetTrustLineFlagsResultCode>(
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
                        return Serializer.Deserialize<Stellar.SetTrustLineFlagsResultCode>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
