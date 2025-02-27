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
    /// <summary>Custom marshaller for Stellar.ClawbackClaimableBalanceResult</summary>
    public static class ClawbackClaimableBalanceResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackClaimableBalanceResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackClaimableBalanceResult
            if (!model.IsDefined(typeof(Stellar.ClawbackClaimableBalanceResult)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackClaimableBalanceResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess));
                metaType.AddSubType(101, typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceDoesNotExist));
                metaType.AddSubType(102, typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer));
                metaType.AddSubType(103, typeof(Stellar.ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClawbackClaimableBalanceResult</summary>
        public static readonly Marshaller<Stellar.ClawbackClaimableBalanceResult> ClawbackClaimableBalanceResultMarshaller = Marshallers.Create<Stellar.ClawbackClaimableBalanceResult>(
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
                        return Serializer.Deserialize<Stellar.ClawbackClaimableBalanceResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
