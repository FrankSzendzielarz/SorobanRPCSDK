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
    /// <summary>Custom marshaller for Stellar.ClawbackClaimableBalanceResult+ClawbackClaimableBalanceSuccess</summary>
    public static class ClawbackClaimableBalanceResultClawbackClaimableBalanceSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackClaimableBalanceResultClawbackClaimableBalanceSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess
            if (!model.IsDefined(typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClawbackClaimableBalanceSuccess</summary>
        public static readonly Marshaller<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess> ClawbackClaimableBalanceSuccessMarshaller = Marshallers.Create<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess>(
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
                        return Serializer.Deserialize<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
