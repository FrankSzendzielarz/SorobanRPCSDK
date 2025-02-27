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
    /// <summary>Custom marshaller for Stellar.LedgerUpgrade+LedgerUpgradeBaseFee</summary>
    public static class LedgerUpgradeLedgerUpgradeBaseFeeGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerUpgradeLedgerUpgradeBaseFeeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerUpgrade.LedgerUpgradeBaseFee
            if (!model.IsDefined(typeof(Stellar.LedgerUpgrade.LedgerUpgradeBaseFee)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerUpgrade.LedgerUpgradeBaseFee), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "newBaseFee");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerUpgrade+LedgerUpgradeBaseFee</summary>
        public static readonly Marshaller<Stellar.LedgerUpgrade.LedgerUpgradeBaseFee> LedgerUpgrade_LedgerUpgradeBaseFeeMarshaller = Marshallers.Create<Stellar.LedgerUpgrade.LedgerUpgradeBaseFee>(
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
                        return Serializer.Deserialize<Stellar.LedgerUpgrade.LedgerUpgradeBaseFee>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
