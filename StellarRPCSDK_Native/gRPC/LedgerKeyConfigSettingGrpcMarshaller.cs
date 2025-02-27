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
    /// <summary>Custom marshaller for Stellar.LedgerKey+ConfigSetting</summary>
    public static class LedgerKeyConfigSettingGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyConfigSettingGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.ConfigSetting
            if (!model.IsDefined(typeof(Stellar.LedgerKey.ConfigSetting)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.ConfigSetting), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(9, "configSetting");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSetting</summary>
        public static readonly Marshaller<Stellar.LedgerKey.ConfigSetting> ConfigSettingMarshaller = Marshallers.Create<Stellar.LedgerKey.ConfigSetting>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.ConfigSetting>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
