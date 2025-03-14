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
    /// <summary>Custom marshaller for Stellar.ClawbackResult+ClawbackSuccess</summary>
    public static class ClawbackResultClawbackSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackResultClawbackSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackResult.ClawbackSuccess
            if (!model.IsDefined(typeof(Stellar.ClawbackResult.ClawbackSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackResult.ClawbackSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClawbackResult+ClawbackSuccess</summary>
        public static readonly Marshaller<Stellar.ClawbackResult.ClawbackSuccess> ClawbackResult_ClawbackSuccessMarshaller = Marshallers.Create<Stellar.ClawbackResult.ClawbackSuccess>(
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
                        return Serializer.Deserialize<Stellar.ClawbackResult.ClawbackSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
