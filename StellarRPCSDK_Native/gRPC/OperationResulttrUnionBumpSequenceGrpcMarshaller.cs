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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+BumpSequence</summary>
    public static class OperationResulttrUnionBumpSequenceGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionBumpSequenceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.BumpSequence
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.BumpSequence)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.BumpSequence), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(12, "bumpSeqResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.OperationResult+trUnion+BumpSequence</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.BumpSequence> OperationResult_trUnion_BumpSequenceMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.BumpSequence>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.BumpSequence>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
