// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.GetFeeStatsResult</summary>
    public static class GetFeeStatsResultGrpcMarshaller
    {
        // Static constructor to configure type
        static GetFeeStatsResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetFeeStatsResult
            if (!model.IsDefined(typeof(Stellar.RPC.GetFeeStatsResult)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetFeeStatsResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "SorobanInclusionFee");
                metaType.Add(2, "InclusionFee");
                metaType.Add(3, "LatestLedger");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.GetFeeStatsResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetFeeStatsResult> GetFeeStatsResultMarshaller = Marshallers.Create<Stellar.RPC.GetFeeStatsResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetFeeStatsResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
