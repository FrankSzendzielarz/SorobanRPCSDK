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
    /// <summary>Custom marshaller for Stellar.ClaimClaimableBalanceResult+ClaimClaimableBalanceSuccess</summary>
    public static class ClaimClaimableBalanceResultClaimClaimableBalanceSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimClaimableBalanceResultClaimClaimableBalanceSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess
            if (!model.IsDefined(typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimClaimableBalanceSuccess</summary>
        public static readonly Marshaller<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess> ClaimClaimableBalanceSuccessMarshaller = Marshallers.Create<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess>(
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
                        return Serializer.Deserialize<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
