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
    /// <summary>Custom marshaller for Stellar.ClaimClaimableBalanceResult+ClaimClaimableBalanceCannotClaim</summary>
    public static class ClaimClaimableBalanceResultClaimClaimableBalanceCannotClaimGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimClaimableBalanceResultClaimClaimableBalanceCannotClaimGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim
            if (!model.IsDefined(typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimClaimableBalanceCannotClaim</summary>
        public static readonly Marshaller<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim> ClaimClaimableBalanceCannotClaimMarshaller = Marshallers.Create<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim>(
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
                        return Serializer.Deserialize<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
