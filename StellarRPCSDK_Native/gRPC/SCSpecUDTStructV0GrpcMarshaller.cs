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
    /// <summary>Custom marshaller for Stellar.SCSpecUDTStructV0</summary>
    public static class SCSpecUDTStructV0GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecUDTStructV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecUDTStructV0
            if (!model.IsDefined(typeof(Stellar.SCSpecUDTStructV0)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecUDTStructV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "doc");
                metaType.Add(2, "lib");
                metaType.Add(3, "name");
                metaType.Add(4, "fields");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCSpecUDTStructV0</summary>
        public static readonly Marshaller<Stellar.SCSpecUDTStructV0> SCSpecUDTStructV0Marshaller = Marshallers.Create<Stellar.SCSpecUDTStructV0>(
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
                        return Serializer.Deserialize<Stellar.SCSpecUDTStructV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
