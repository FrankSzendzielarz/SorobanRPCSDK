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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractBandwidthV0EncodeRequest</summary>
    public static class ConfigSettingContractBandwidthV0EncodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractBandwidthV0EncodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractBandwidthV0EncodeRequest
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractBandwidthV0EncodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractBandwidthV0EncodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractBandwidthV0EncodeRequest</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractBandwidthV0EncodeRequest> ConfigSettingContractBandwidthV0EncodeRequestMarshaller = Marshallers.Create<Stellar.ConfigSettingContractBandwidthV0EncodeRequest>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractBandwidthV0EncodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
