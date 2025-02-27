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
    /// <summary>Custom marshaller for Stellar.ChangeTrustResult+ChangeTrustNotAuthMaintainLiabilities</summary>
    public static class ChangeTrustResultChangeTrustNotAuthMaintainLiabilitiesGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustResultChangeTrustNotAuthMaintainLiabilitiesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities
            if (!model.IsDefined(typeof(Stellar.ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ChangeTrustResult+ChangeTrustNotAuthMaintainLiabilities</summary>
        public static readonly Marshaller<Stellar.ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities> ChangeTrustResult_ChangeTrustNotAuthMaintainLiabilitiesMarshaller = Marshallers.Create<Stellar.ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
