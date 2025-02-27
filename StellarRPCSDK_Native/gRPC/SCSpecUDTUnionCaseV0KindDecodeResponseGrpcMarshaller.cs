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
    /// <summary>Custom marshaller for Stellar.SCSpecUDTUnionCaseV0KindDecodeResponse</summary>
    public static class SCSpecUDTUnionCaseV0KindDecodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecUDTUnionCaseV0KindDecodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecUDTUnionCaseV0KindDecodeResponse
            if (!model.IsDefined(typeof(Stellar.SCSpecUDTUnionCaseV0KindDecodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecUDTUnionCaseV0KindDecodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecUDTUnionCaseV0KindDecodeResponse</summary>
        public static readonly Marshaller<Stellar.SCSpecUDTUnionCaseV0KindDecodeResponse> SCSpecUDTUnionCaseV0KindDecodeResponseMarshaller = Marshallers.Create<Stellar.SCSpecUDTUnionCaseV0KindDecodeResponse>(
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
                        return Serializer.Deserialize<Stellar.SCSpecUDTUnionCaseV0KindDecodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
