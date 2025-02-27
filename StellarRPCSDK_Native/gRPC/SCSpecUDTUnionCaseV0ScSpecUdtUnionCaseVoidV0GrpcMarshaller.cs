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
    /// <summary>Custom marshaller for Stellar.SCSpecUDTUnionCaseV0+ScSpecUdtUnionCaseVoidV0</summary>
    public static class SCSpecUDTUnionCaseV0ScSpecUdtUnionCaseVoidV0GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecUDTUnionCaseV0ScSpecUdtUnionCaseVoidV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseVoidV0
            if (!model.IsDefined(typeof(Stellar.SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseVoidV0)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseVoidV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "voidCase");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCSpecUDTUnionCaseV0+ScSpecUdtUnionCaseVoidV0</summary>
        public static readonly Marshaller<Stellar.SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseVoidV0> SCSpecUDTUnionCaseV0_ScSpecUdtUnionCaseVoidV0Marshaller = Marshallers.Create<Stellar.SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseVoidV0>(
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
                        return Serializer.Deserialize<Stellar.SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseVoidV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
