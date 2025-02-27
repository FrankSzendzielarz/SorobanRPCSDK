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
    /// <summary>Custom marshaller for Stellar.RPC.InclusionFee</summary>
    public static class InclusionFeeGrpcMarshaller
    {
        // Static constructor to configure type
        static InclusionFeeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.InclusionFee
            if (!model.IsDefined(typeof(Stellar.RPC.InclusionFee)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.InclusionFee), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Max");
                metaType.Add(2, "Min");
                metaType.Add(3, "Mode");
                metaType.Add(4, "P10");
                metaType.Add(5, "P20");
                metaType.Add(6, "P30");
                metaType.Add(7, "P40");
                metaType.Add(8, "P50");
                metaType.Add(9, "P60");
                metaType.Add(10, "P70");
                metaType.Add(11, "P80");
                metaType.Add(12, "P90");
                metaType.Add(13, "P95");
                metaType.Add(14, "P99");
                metaType.Add(15, "TransactionCount");
                metaType.Add(16, "LedgerCount");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.InclusionFee</summary>
        public static readonly Marshaller<Stellar.RPC.InclusionFee> InclusionFeeMarshaller = Marshallers.Create<Stellar.RPC.InclusionFee>(
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
                        return Serializer.Deserialize<Stellar.RPC.InclusionFee>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
