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
    /// <summary>Custom marshaller for Stellar.SCSpecUDTUnionV0</summary>
    public static class SCSpecUDTUnionV0GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecUDTUnionV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecUDTUnionV0
            if (!model.IsDefined(typeof(Stellar.SCSpecUDTUnionV0)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecUDTUnionV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "doc");
                metaType.Add(2, "lib");
                metaType.Add(3, "name");
                metaType.Add(4, "cases");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecUDTUnionV0</summary>
        public static readonly Marshaller<Stellar.SCSpecUDTUnionV0> SCSpecUDTUnionV0Marshaller = Marshallers.Create<Stellar.SCSpecUDTUnionV0>(
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
                        return Serializer.Deserialize<Stellar.SCSpecUDTUnionV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
