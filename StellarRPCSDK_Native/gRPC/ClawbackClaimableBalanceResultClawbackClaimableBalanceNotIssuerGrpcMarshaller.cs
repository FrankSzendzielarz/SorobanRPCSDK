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
    /// <summary>Custom marshaller for Stellar.ClawbackClaimableBalanceResult+ClawbackClaimableBalanceNotIssuer</summary>
    public static class ClawbackClaimableBalanceResultClawbackClaimableBalanceNotIssuerGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackClaimableBalanceResultClawbackClaimableBalanceNotIssuerGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer
            if (!model.IsDefined(typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClawbackClaimableBalanceResult+ClawbackClaimableBalanceNotIssuer</summary>
        public static readonly Marshaller<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer> ClawbackClaimableBalanceResult_ClawbackClaimableBalanceNotIssuerMarshaller = Marshallers.Create<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer>(
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
                        return Serializer.Deserialize<Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
