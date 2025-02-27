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
    /// <summary>Custom marshaller for Stellar.InvokeContractArgs</summary>
    public static class InvokeContractArgsGrpcMarshaller
    {
        // Static constructor to configure type
        static InvokeContractArgsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InvokeContractArgs
            if (!model.IsDefined(typeof(Stellar.InvokeContractArgs)))
            {
                var metaType = model.Add(typeof(Stellar.InvokeContractArgs), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "contractAddress");
                metaType.Add(2, "functionName");
                metaType.Add(3, "args");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InvokeContractArgs</summary>
        public static readonly Marshaller<Stellar.InvokeContractArgs> InvokeContractArgsMarshaller = Marshallers.Create<Stellar.InvokeContractArgs>(
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
                        return Serializer.Deserialize<Stellar.InvokeContractArgs>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
