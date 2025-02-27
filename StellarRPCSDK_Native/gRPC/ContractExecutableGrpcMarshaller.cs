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
    /// <summary>Custom marshaller for Stellar.ContractExecutable</summary>
    public static class ContractExecutableGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractExecutableGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractExecutable
            if (!model.IsDefined(typeof(Stellar.ContractExecutable)))
            {
                var metaType = model.Add(typeof(Stellar.ContractExecutable), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ContractExecutable.ContractExecutableWasm));
                metaType.AddSubType(101, typeof(Stellar.ContractExecutable.ContractExecutableStellarAsset));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ContractExecutable</summary>
        public static readonly Marshaller<Stellar.ContractExecutable> ContractExecutableMarshaller = Marshallers.Create<Stellar.ContractExecutable>(
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
                        return Serializer.Deserialize<Stellar.ContractExecutable>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
