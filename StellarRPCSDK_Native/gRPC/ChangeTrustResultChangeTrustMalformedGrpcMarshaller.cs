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
    /// <summary>Custom marshaller for Stellar.ChangeTrustResult+ChangeTrustMalformed</summary>
    public static class ChangeTrustResultChangeTrustMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustResultChangeTrustMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustResult.ChangeTrustMalformed
            if (!model.IsDefined(typeof(Stellar.ChangeTrustResult.ChangeTrustMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustResult.ChangeTrustMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ChangeTrustResult+ChangeTrustMalformed</summary>
        public static readonly Marshaller<Stellar.ChangeTrustResult.ChangeTrustMalformed> ChangeTrustResult_ChangeTrustMalformedMarshaller = Marshallers.Create<Stellar.ChangeTrustResult.ChangeTrustMalformed>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustResult.ChangeTrustMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
