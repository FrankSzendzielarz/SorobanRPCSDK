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
    /// <summary>Custom marshaller for Stellar.ContractCodeEntry+extUnion</summary>
    public static class ContractCodeEntryextUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractCodeEntryextUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractCodeEntry.extUnion
            if (!model.IsDefined(typeof(Stellar.ContractCodeEntry.extUnion)))
            {
                var metaType = model.Add(typeof(Stellar.ContractCodeEntry.extUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ContractCodeEntry.extUnion.case_0));
                metaType.AddSubType(101, typeof(Stellar.ContractCodeEntry.extUnion.case_1));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ContractCodeEntry+extUnion</summary>
        public static readonly Marshaller<Stellar.ContractCodeEntry.extUnion> ContractCodeEntry_extUnionMarshaller = Marshallers.Create<Stellar.ContractCodeEntry.extUnion>(
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
                        return Serializer.Deserialize<Stellar.ContractCodeEntry.extUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
