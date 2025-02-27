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
    /// <summary>Custom marshaller for Stellar.ClaimClaimableBalanceResult</summary>
    public static class ClaimClaimableBalanceResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimClaimableBalanceResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimClaimableBalanceResult
            if (!model.IsDefined(typeof(Stellar.ClaimClaimableBalanceResult)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimClaimableBalanceResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess));
                metaType.AddSubType(101, typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceDoesNotExist));
                metaType.AddSubType(102, typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim));
                metaType.AddSubType(103, typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull));
                metaType.AddSubType(104, typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust));
                metaType.AddSubType(105, typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceNotAuthorized));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClaimClaimableBalanceResult</summary>
        public static readonly Marshaller<Stellar.ClaimClaimableBalanceResult> ClaimClaimableBalanceResultMarshaller = Marshallers.Create<Stellar.ClaimClaimableBalanceResult>(
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
                        return Serializer.Deserialize<Stellar.ClaimClaimableBalanceResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
