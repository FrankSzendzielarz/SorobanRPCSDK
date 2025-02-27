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
    /// <summary>Custom marshaller for Stellar.LedgerUpgrade</summary>
    public static class LedgerUpgradeGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerUpgradeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerUpgrade
            if (!model.IsDefined(typeof(Stellar.LedgerUpgrade)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerUpgrade), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LedgerUpgrade.LedgerUpgradeVersion));
                metaType.AddSubType(101, typeof(Stellar.LedgerUpgrade.LedgerUpgradeBaseFee));
                metaType.AddSubType(102, typeof(Stellar.LedgerUpgrade.LedgerUpgradeMaxTxSetSize));
                metaType.AddSubType(103, typeof(Stellar.LedgerUpgrade.LedgerUpgradeBaseReserve));
                metaType.AddSubType(104, typeof(Stellar.LedgerUpgrade.LedgerUpgradeFlags));
                metaType.AddSubType(105, typeof(Stellar.LedgerUpgrade.LedgerUpgradeConfig));
                metaType.AddSubType(106, typeof(Stellar.LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerUpgrade</summary>
        public static readonly Marshaller<Stellar.LedgerUpgrade> LedgerUpgradeMarshaller = Marshallers.Create<Stellar.LedgerUpgrade>(
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
                        return Serializer.Deserialize<Stellar.LedgerUpgrade>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
