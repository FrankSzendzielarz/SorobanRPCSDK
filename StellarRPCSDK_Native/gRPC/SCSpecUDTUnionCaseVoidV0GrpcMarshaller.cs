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
    /// <summary>Custom marshaller for Stellar.SCSpecUDTUnionCaseVoidV0</summary>
    public static class SCSpecUDTUnionCaseVoidV0GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecUDTUnionCaseVoidV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecUDTUnionCaseVoidV0
            if (!model.IsDefined(typeof(Stellar.SCSpecUDTUnionCaseVoidV0)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecUDTUnionCaseVoidV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "doc");
                metaType.Add(2, "name");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecUDTUnionCaseVoidV0</summary>
        public static readonly Marshaller<Stellar.SCSpecUDTUnionCaseVoidV0> SCSpecUDTUnionCaseVoidV0Marshaller = Marshallers.Create<Stellar.SCSpecUDTUnionCaseVoidV0>(
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
                        return Serializer.Deserialize<Stellar.SCSpecUDTUnionCaseVoidV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
