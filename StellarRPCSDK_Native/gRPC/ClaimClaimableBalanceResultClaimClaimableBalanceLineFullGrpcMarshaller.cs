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
    /// <summary>Custom marshaller for Stellar.ClaimClaimableBalanceResult+ClaimClaimableBalanceLineFull</summary>
    public static class ClaimClaimableBalanceResultClaimClaimableBalanceLineFullGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimClaimableBalanceResultClaimClaimableBalanceLineFullGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull
            if (!model.IsDefined(typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClaimClaimableBalanceResult+ClaimClaimableBalanceLineFull</summary>
        public static readonly Marshaller<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull> ClaimClaimableBalanceResult_ClaimClaimableBalanceLineFullMarshaller = Marshallers.Create<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull>(
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
                        return Serializer.Deserialize<Stellar.ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
