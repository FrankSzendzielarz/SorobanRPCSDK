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
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry+ConfigSettingStateArchival</summary>
    public static class ConfigSettingEntryConfigSettingStateArchivalGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryConfigSettingStateArchivalGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry.ConfigSettingStateArchival
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry.ConfigSettingStateArchival)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry.ConfigSettingStateArchival), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(11, "stateArchivalSettings");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ConfigSettingEntry+ConfigSettingStateArchival</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry.ConfigSettingStateArchival> ConfigSettingEntry_ConfigSettingStateArchivalMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry.ConfigSettingStateArchival>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry.ConfigSettingStateArchival>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
