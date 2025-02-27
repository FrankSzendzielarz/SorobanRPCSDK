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
    /// <summary>Custom marshaller for Stellar.CreateContractArgsV2</summary>
    public static class CreateContractArgsV2GrpcMarshaller
    {
        // Static constructor to configure type
        static CreateContractArgsV2GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateContractArgsV2
            if (!model.IsDefined(typeof(Stellar.CreateContractArgsV2)))
            {
                var metaType = model.Add(typeof(Stellar.CreateContractArgsV2), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "contractIDPreimage");
                metaType.Add(2, "executable");
                metaType.Add(3, "constructorArgs");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.CreateContractArgsV2</summary>
        public static readonly Marshaller<Stellar.CreateContractArgsV2> CreateContractArgsV2Marshaller = Marshallers.Create<Stellar.CreateContractArgsV2>(
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
                        return Serializer.Deserialize<Stellar.CreateContractArgsV2>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
