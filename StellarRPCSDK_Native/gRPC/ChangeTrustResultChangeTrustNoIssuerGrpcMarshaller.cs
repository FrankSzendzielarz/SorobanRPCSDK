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
    /// <summary>Custom marshaller for Stellar.ChangeTrustResult+ChangeTrustNoIssuer</summary>
    public static class ChangeTrustResultChangeTrustNoIssuerGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustResultChangeTrustNoIssuerGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustResult.ChangeTrustNoIssuer
            if (!model.IsDefined(typeof(Stellar.ChangeTrustResult.ChangeTrustNoIssuer)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustResult.ChangeTrustNoIssuer), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ChangeTrustNoIssuer</summary>
        public static readonly Marshaller<Stellar.ChangeTrustResult.ChangeTrustNoIssuer> ChangeTrustNoIssuerMarshaller = Marshallers.Create<Stellar.ChangeTrustResult.ChangeTrustNoIssuer>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustResult.ChangeTrustNoIssuer>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
