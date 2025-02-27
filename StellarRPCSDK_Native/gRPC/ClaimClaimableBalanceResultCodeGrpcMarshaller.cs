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
    /// <summary>Custom marshaller for Stellar.ClaimClaimableBalanceResultCode</summary>
    public static class ClaimClaimableBalanceResultCodeGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimClaimableBalanceResultCodeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimClaimableBalanceResultCode
            if (!model.IsDefined(typeof(Stellar.ClaimClaimableBalanceResultCode)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimClaimableBalanceResultCode), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimClaimableBalanceResultCode</summary>
        public static readonly Marshaller<Stellar.ClaimClaimableBalanceResultCode> ClaimClaimableBalanceResultCodeMarshaller = Marshallers.Create<Stellar.ClaimClaimableBalanceResultCode>(
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
                        return Serializer.Deserialize<Stellar.ClaimClaimableBalanceResultCode>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
