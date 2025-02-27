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
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry+ConfigSettingEvictionIterator</summary>
    public static class ConfigSettingEntryConfigSettingEvictionIteratorGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryConfigSettingEvictionIteratorGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry.ConfigSettingEvictionIterator
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry.ConfigSettingEvictionIterator)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry.ConfigSettingEvictionIterator), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(14, "evictionIterator");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ConfigSettingEntry+ConfigSettingEvictionIterator</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry.ConfigSettingEvictionIterator> ConfigSettingEntry_ConfigSettingEvictionIteratorMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry.ConfigSettingEvictionIterator>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry.ConfigSettingEvictionIterator>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
