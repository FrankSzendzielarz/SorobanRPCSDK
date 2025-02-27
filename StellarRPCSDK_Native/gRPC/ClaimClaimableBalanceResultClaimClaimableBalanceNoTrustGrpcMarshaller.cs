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
    /// <summary>Custom marshaller for Stellar.ClaimClaimableBalanceResult+ClaimClaimableBalanceNoTrust</summary>
    public static class ClaimClaimableBalanceResultClaimClaimableBalanceNoTrustGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimClaimableBalanceResultClaimClaimableBalanceNoTrustGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust
            if (!model.IsDefined(typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClaimClaimableBalanceResult+ClaimClaimableBalanceNoTrust</summary>
        public static readonly Marshaller<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust> ClaimClaimableBalanceResult_ClaimClaimableBalanceNoTrustMarshaller = Marshallers.Create<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust>(
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
                        return Serializer.Deserialize<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
