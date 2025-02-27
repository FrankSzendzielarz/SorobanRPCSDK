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
    /// <summary>Custom marshaller for Stellar.LedgerEntry+dataUnion</summary>
    public static class LedgerEntrydataUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntrydataUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntry.dataUnion
            if (!model.IsDefined(typeof(Stellar.LedgerEntry.dataUnion)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntry.dataUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LedgerEntry.dataUnion.Account));
                metaType.AddSubType(101, typeof(Stellar.LedgerEntry.dataUnion.Trustline));
                metaType.AddSubType(102, typeof(Stellar.LedgerEntry.dataUnion.Offer));
                metaType.AddSubType(103, typeof(Stellar.LedgerEntry.dataUnion.Data));
                metaType.AddSubType(104, typeof(Stellar.LedgerEntry.dataUnion.ClaimableBalance));
                metaType.AddSubType(105, typeof(Stellar.LedgerEntry.dataUnion.LiquidityPool));
                metaType.AddSubType(106, typeof(Stellar.LedgerEntry.dataUnion.ContractData));
                metaType.AddSubType(107, typeof(Stellar.LedgerEntry.dataUnion.ContractCode));
                metaType.AddSubType(108, typeof(Stellar.LedgerEntry.dataUnion.ConfigSetting));
                metaType.AddSubType(109, typeof(Stellar.LedgerEntry.dataUnion.Ttl));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for dataUnion</summary>
        public static readonly Marshaller<Stellar.LedgerEntry.dataUnion> dataUnionMarshaller = Marshallers.Create<Stellar.LedgerEntry.dataUnion>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntry.dataUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
