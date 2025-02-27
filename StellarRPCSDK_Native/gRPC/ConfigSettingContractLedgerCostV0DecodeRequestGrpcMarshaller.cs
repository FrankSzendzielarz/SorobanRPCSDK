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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractLedgerCostV0DecodeRequest</summary>
    public static class ConfigSettingContractLedgerCostV0DecodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractLedgerCostV0DecodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractLedgerCostV0DecodeRequest
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractLedgerCostV0DecodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractLedgerCostV0DecodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractLedgerCostV0DecodeRequest</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractLedgerCostV0DecodeRequest> ConfigSettingContractLedgerCostV0DecodeRequestMarshaller = Marshallers.Create<Stellar.ConfigSettingContractLedgerCostV0DecodeRequest>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractLedgerCostV0DecodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
