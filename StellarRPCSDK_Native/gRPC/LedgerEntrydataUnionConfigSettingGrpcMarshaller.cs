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
    /// <summary>Custom marshaller for Stellar.LedgerEntry+dataUnion+ConfigSetting</summary>
    public static class LedgerEntrydataUnionConfigSettingGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntrydataUnionConfigSettingGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntry.dataUnion.ConfigSetting
            if (!model.IsDefined(typeof(Stellar.LedgerEntry.dataUnion.ConfigSetting)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntry.dataUnion.ConfigSetting), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(9, "configSetting");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerEntry+dataUnion+ConfigSetting</summary>
        public static readonly Marshaller<Stellar.LedgerEntry.dataUnion.ConfigSetting> LedgerEntry_dataUnion_ConfigSettingMarshaller = Marshallers.Create<Stellar.LedgerEntry.dataUnion.ConfigSetting>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntry.dataUnion.ConfigSetting>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
