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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractComputeV0DecodeRequest</summary>
    public static class ConfigSettingContractComputeV0DecodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractComputeV0DecodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractComputeV0DecodeRequest
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractComputeV0DecodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractComputeV0DecodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractComputeV0DecodeRequest</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractComputeV0DecodeRequest> ConfigSettingContractComputeV0DecodeRequestMarshaller = Marshallers.Create<Stellar.ConfigSettingContractComputeV0DecodeRequest>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractComputeV0DecodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
