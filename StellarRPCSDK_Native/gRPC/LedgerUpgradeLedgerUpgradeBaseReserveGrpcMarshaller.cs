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
    /// <summary>Custom marshaller for Stellar.LedgerUpgrade+LedgerUpgradeBaseReserve</summary>
    public static class LedgerUpgradeLedgerUpgradeBaseReserveGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerUpgradeLedgerUpgradeBaseReserveGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerUpgrade.LedgerUpgradeBaseReserve
            if (!model.IsDefined(typeof(Stellar.LedgerUpgrade.LedgerUpgradeBaseReserve)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerUpgrade.LedgerUpgradeBaseReserve), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "newBaseReserve");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerUpgrade+LedgerUpgradeBaseReserve</summary>
        public static readonly Marshaller<Stellar.LedgerUpgrade.LedgerUpgradeBaseReserve> LedgerUpgrade_LedgerUpgradeBaseReserveMarshaller = Marshallers.Create<Stellar.LedgerUpgrade.LedgerUpgradeBaseReserve>(
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
                        return Serializer.Deserialize<Stellar.LedgerUpgrade.LedgerUpgradeBaseReserve>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
