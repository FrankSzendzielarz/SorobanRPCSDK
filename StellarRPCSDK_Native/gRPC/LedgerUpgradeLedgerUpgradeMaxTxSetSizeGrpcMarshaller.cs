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
    /// <summary>Custom marshaller for Stellar.LedgerUpgrade+LedgerUpgradeMaxTxSetSize</summary>
    public static class LedgerUpgradeLedgerUpgradeMaxTxSetSizeGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerUpgradeLedgerUpgradeMaxTxSetSizeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerUpgrade.LedgerUpgradeMaxTxSetSize
            if (!model.IsDefined(typeof(Stellar.LedgerUpgrade.LedgerUpgradeMaxTxSetSize)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerUpgrade.LedgerUpgradeMaxTxSetSize), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "newMaxTxSetSize");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerUpgrade+LedgerUpgradeMaxTxSetSize</summary>
        public static readonly Marshaller<Stellar.LedgerUpgrade.LedgerUpgradeMaxTxSetSize> LedgerUpgrade_LedgerUpgradeMaxTxSetSizeMarshaller = Marshallers.Create<Stellar.LedgerUpgrade.LedgerUpgradeMaxTxSetSize>(
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
                        return Serializer.Deserialize<Stellar.LedgerUpgrade.LedgerUpgradeMaxTxSetSize>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
