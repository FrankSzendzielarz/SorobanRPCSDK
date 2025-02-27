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
    /// <summary>Custom marshaller for Stellar.ClawbackClaimableBalanceResult+ClawbackClaimableBalanceNotClawbackEnabled</summary>
    public static class ClawbackClaimableBalanceResultClawbackClaimableBalanceNotClawbackEnabledGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackClaimableBalanceResultClawbackClaimableBalanceNotClawbackEnabledGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled
            if (!model.IsDefined(typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClawbackClaimableBalanceNotClawbackEnabled</summary>
        public static readonly Marshaller<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled> ClawbackClaimableBalanceNotClawbackEnabledMarshaller = Marshallers.Create<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled>(
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
                        return Serializer.Deserialize<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
