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
    /// <summary>Custom marshaller for Stellar.ContractEvent+bodyUnion</summary>
    public static class ContractEventbodyUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractEventbodyUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractEvent.bodyUnion
            if (!model.IsDefined(typeof(Stellar.ContractEvent.bodyUnion)))
            {
                var metaType = model.Add(typeof(Stellar.ContractEvent.bodyUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ContractEvent.bodyUnion.case_0));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for bodyUnion</summary>
        public static readonly Marshaller<Stellar.ContractEvent.bodyUnion> bodyUnionMarshaller = Marshallers.Create<Stellar.ContractEvent.bodyUnion>(
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
                        return Serializer.Deserialize<Stellar.ContractEvent.bodyUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
