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
    /// <summary>Custom marshaller for Stellar.SCContractInstance</summary>
    public static class SCContractInstanceGrpcMarshaller
    {
        // Static constructor to configure type
        static SCContractInstanceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCContractInstance
            if (!model.IsDefined(typeof(Stellar.SCContractInstance)))
            {
                var metaType = model.Add(typeof(Stellar.SCContractInstance), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "executable");
                metaType.Add(2, "storage");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCContractInstance</summary>
        public static readonly Marshaller<Stellar.SCContractInstance> SCContractInstanceMarshaller = Marshallers.Create<Stellar.SCContractInstance>(
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
                        return Serializer.Deserialize<Stellar.SCContractInstance>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
