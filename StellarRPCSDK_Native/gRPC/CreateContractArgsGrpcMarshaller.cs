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
    /// <summary>Custom marshaller for Stellar.CreateContractArgs</summary>
    public static class CreateContractArgsGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateContractArgsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateContractArgs
            if (!model.IsDefined(typeof(Stellar.CreateContractArgs)))
            {
                var metaType = model.Add(typeof(Stellar.CreateContractArgs), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "contractIDPreimage");
                metaType.Add(2, "executable");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.CreateContractArgs</summary>
        public static readonly Marshaller<Stellar.CreateContractArgs> CreateContractArgsMarshaller = Marshallers.Create<Stellar.CreateContractArgs>(
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
                        return Serializer.Deserialize<Stellar.CreateContractArgs>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
