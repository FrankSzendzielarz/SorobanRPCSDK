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
    /// <summary>Custom marshaller for Stellar.ChangeTrustResult+ChangeTrustSelfNotAllowed</summary>
    public static class ChangeTrustResultChangeTrustSelfNotAllowedGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustResultChangeTrustSelfNotAllowedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustResult.ChangeTrustSelfNotAllowed
            if (!model.IsDefined(typeof(Stellar.ChangeTrustResult.ChangeTrustSelfNotAllowed)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustResult.ChangeTrustSelfNotAllowed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ChangeTrustResult+ChangeTrustSelfNotAllowed</summary>
        public static readonly Marshaller<Stellar.ChangeTrustResult.ChangeTrustSelfNotAllowed> ChangeTrustResult_ChangeTrustSelfNotAllowedMarshaller = Marshallers.Create<Stellar.ChangeTrustResult.ChangeTrustSelfNotAllowed>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustResult.ChangeTrustSelfNotAllowed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
