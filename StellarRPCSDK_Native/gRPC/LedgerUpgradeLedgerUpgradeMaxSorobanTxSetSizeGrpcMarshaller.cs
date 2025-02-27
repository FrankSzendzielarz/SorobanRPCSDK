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
    /// <summary>Custom marshaller for Stellar.LedgerUpgrade+LedgerUpgradeMaxSorobanTxSetSize</summary>
    public static class LedgerUpgradeLedgerUpgradeMaxSorobanTxSetSizeGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerUpgradeLedgerUpgradeMaxSorobanTxSetSizeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize
            if (!model.IsDefined(typeof(Stellar.LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(7, "newMaxSorobanTxSetSize");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LedgerUpgradeMaxSorobanTxSetSize</summary>
        public static readonly Marshaller<Stellar.LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize> LedgerUpgradeMaxSorobanTxSetSizeMarshaller = Marshallers.Create<Stellar.LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize>(
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
                        return Serializer.Deserialize<Stellar.LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
