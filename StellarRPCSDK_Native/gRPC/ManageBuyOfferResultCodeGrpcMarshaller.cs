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
    /// <summary>Custom marshaller for Stellar.ManageBuyOfferResultCode</summary>
    public static class ManageBuyOfferResultCodeGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageBuyOfferResultCodeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageBuyOfferResultCode
            if (!model.IsDefined(typeof(Stellar.ManageBuyOfferResultCode)))
            {
                var metaType = model.Add(typeof(Stellar.ManageBuyOfferResultCode), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageBuyOfferResultCode</summary>
        public static readonly Marshaller<Stellar.ManageBuyOfferResultCode> ManageBuyOfferResultCodeMarshaller = Marshallers.Create<Stellar.ManageBuyOfferResultCode>(
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
                        return Serializer.Deserialize<Stellar.ManageBuyOfferResultCode>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
