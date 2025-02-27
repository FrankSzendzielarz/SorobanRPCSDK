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
    /// <summary>Custom marshaller for Stellar.ContractCodeEntry+extUnion+v1Struct</summary>
    public static class ContractCodeEntryextUnionv1StructGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractCodeEntryextUnionv1StructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractCodeEntry.extUnion.v1Struct
            if (!model.IsDefined(typeof(Stellar.ContractCodeEntry.extUnion.v1Struct)))
            {
                var metaType = model.Add(typeof(Stellar.ContractCodeEntry.extUnion.v1Struct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "costInputs");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for v1Struct</summary>
        public static readonly Marshaller<Stellar.ContractCodeEntry.extUnion.v1Struct> v1StructMarshaller = Marshallers.Create<Stellar.ContractCodeEntry.extUnion.v1Struct>(
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
                        return Serializer.Deserialize<Stellar.ContractCodeEntry.extUnion.v1Struct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
