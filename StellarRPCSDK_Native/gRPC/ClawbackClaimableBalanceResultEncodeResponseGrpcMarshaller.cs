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
    /// <summary>Custom marshaller for Stellar.ClawbackClaimableBalanceResultEncodeResponse</summary>
    public static class ClawbackClaimableBalanceResultEncodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackClaimableBalanceResultEncodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackClaimableBalanceResultEncodeResponse
            if (!model.IsDefined(typeof(Stellar.ClawbackClaimableBalanceResultEncodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackClaimableBalanceResultEncodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClawbackClaimableBalanceResultEncodeResponse</summary>
        public static readonly Marshaller<Stellar.ClawbackClaimableBalanceResultEncodeResponse> ClawbackClaimableBalanceResultEncodeResponseMarshaller = Marshallers.Create<Stellar.ClawbackClaimableBalanceResultEncodeResponse>(
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
                        return Serializer.Deserialize<Stellar.ClawbackClaimableBalanceResultEncodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
