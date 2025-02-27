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
    /// <summary>Custom marshaller for Stellar.ChangeTrustResult+ChangeTrustCannotDelete</summary>
    public static class ChangeTrustResultChangeTrustCannotDeleteGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustResultChangeTrustCannotDeleteGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustResult.ChangeTrustCannotDelete
            if (!model.IsDefined(typeof(Stellar.ChangeTrustResult.ChangeTrustCannotDelete)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustResult.ChangeTrustCannotDelete), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ChangeTrustResult+ChangeTrustCannotDelete</summary>
        public static readonly Marshaller<Stellar.ChangeTrustResult.ChangeTrustCannotDelete> ChangeTrustResult_ChangeTrustCannotDeleteMarshaller = Marshallers.Create<Stellar.ChangeTrustResult.ChangeTrustCannotDelete>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustResult.ChangeTrustCannotDelete>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
