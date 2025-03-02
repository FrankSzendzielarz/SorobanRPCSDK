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
    /// <summary>Custom marshaller for Stellar.ContractExecutable+ContractExecutableStellarAsset</summary>
    public static class ContractExecutableContractExecutableStellarAssetGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractExecutableContractExecutableStellarAssetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractExecutable.ContractExecutableStellarAsset
            if (!model.IsDefined(typeof(Stellar.ContractExecutable.ContractExecutableStellarAsset)))
            {
                var metaType = model.Add(typeof(Stellar.ContractExecutable.ContractExecutableStellarAsset), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ContractExecutable+ContractExecutableStellarAsset</summary>
        public static readonly Marshaller<Stellar.ContractExecutable.ContractExecutableStellarAsset> ContractExecutable_ContractExecutableStellarAssetMarshaller = Marshallers.Create<Stellar.ContractExecutable.ContractExecutableStellarAsset>(
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
                        return Serializer.Deserialize<Stellar.ContractExecutable.ContractExecutableStellarAsset>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
