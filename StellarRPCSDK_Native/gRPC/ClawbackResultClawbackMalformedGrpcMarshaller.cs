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
    /// <summary>Custom marshaller for Stellar.ClawbackResult+ClawbackMalformed</summary>
    public static class ClawbackResultClawbackMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackResultClawbackMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackResult.ClawbackMalformed
            if (!model.IsDefined(typeof(Stellar.ClawbackResult.ClawbackMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackResult.ClawbackMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClawbackResult+ClawbackMalformed</summary>
        public static readonly Marshaller<Stellar.ClawbackResult.ClawbackMalformed> ClawbackResult_ClawbackMalformedMarshaller = Marshallers.Create<Stellar.ClawbackResult.ClawbackMalformed>(
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
                        return Serializer.Deserialize<Stellar.ClawbackResult.ClawbackMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
