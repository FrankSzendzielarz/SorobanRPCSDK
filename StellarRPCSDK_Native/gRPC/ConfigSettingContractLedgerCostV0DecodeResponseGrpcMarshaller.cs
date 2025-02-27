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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractLedgerCostV0DecodeResponse</summary>
    public static class ConfigSettingContractLedgerCostV0DecodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractLedgerCostV0DecodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractLedgerCostV0DecodeResponse
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractLedgerCostV0DecodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractLedgerCostV0DecodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ConfigSettingContractLedgerCostV0DecodeResponse</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractLedgerCostV0DecodeResponse> ConfigSettingContractLedgerCostV0DecodeResponseMarshaller = Marshallers.Create<Stellar.ConfigSettingContractLedgerCostV0DecodeResponse>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractLedgerCostV0DecodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
