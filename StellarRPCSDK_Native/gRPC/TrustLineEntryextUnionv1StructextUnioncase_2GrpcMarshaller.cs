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
    /// <summary>Custom marshaller for Stellar.TrustLineEntry+extUnion+v1Struct+extUnion+case_2</summary>
    public static class TrustLineEntryextUnionv1StructextUnioncase_2GrpcMarshaller
    {
        // Static constructor to configure type
        static TrustLineEntryextUnionv1StructextUnioncase_2GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TrustLineEntry.extUnion.v1Struct.extUnion.case_2
            if (!model.IsDefined(typeof(Stellar.TrustLineEntry.extUnion.v1Struct.extUnion.case_2)))
            {
                var metaType = model.Add(typeof(Stellar.TrustLineEntry.extUnion.v1Struct.extUnion.case_2), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "v2");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for case_2</summary>
        public static readonly Marshaller<Stellar.TrustLineEntry.extUnion.v1Struct.extUnion.case_2> case_2Marshaller = Marshallers.Create<Stellar.TrustLineEntry.extUnion.v1Struct.extUnion.case_2>(
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
                        return Serializer.Deserialize<Stellar.TrustLineEntry.extUnion.v1Struct.extUnion.case_2>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
