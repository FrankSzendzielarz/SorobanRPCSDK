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
    /// <summary>Custom marshaller for Stellar.CreateClaimableBalanceResult</summary>
    public static class CreateClaimableBalanceResultGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateClaimableBalanceResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateClaimableBalanceResult
            if (!model.IsDefined(typeof(Stellar.CreateClaimableBalanceResult)))
            {
                var metaType = model.Add(typeof(Stellar.CreateClaimableBalanceResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceSuccess));
                metaType.AddSubType(101, typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceMalformed));
                metaType.AddSubType(102, typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceLowReserve));
                metaType.AddSubType(103, typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceNoTrust));
                metaType.AddSubType(104, typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized));
                metaType.AddSubType(105, typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.CreateClaimableBalanceResult</summary>
        public static readonly Marshaller<Stellar.CreateClaimableBalanceResult> CreateClaimableBalanceResultMarshaller = Marshallers.Create<Stellar.CreateClaimableBalanceResult>(
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
                        return Serializer.Deserialize<Stellar.CreateClaimableBalanceResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
