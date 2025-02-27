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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractHistoricalDataV0EncodeResponse</summary>
    public static class ConfigSettingContractHistoricalDataV0EncodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractHistoricalDataV0EncodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractHistoricalDataV0EncodeResponse
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractHistoricalDataV0EncodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractHistoricalDataV0EncodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ConfigSettingContractHistoricalDataV0EncodeResponse</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractHistoricalDataV0EncodeResponse> ConfigSettingContractHistoricalDataV0EncodeResponseMarshaller = Marshallers.Create<Stellar.ConfigSettingContractHistoricalDataV0EncodeResponse>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractHistoricalDataV0EncodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
