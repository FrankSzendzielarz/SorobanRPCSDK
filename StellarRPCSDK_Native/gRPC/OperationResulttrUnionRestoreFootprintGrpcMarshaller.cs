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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+RestoreFootprint</summary>
    public static class OperationResulttrUnionRestoreFootprintGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionRestoreFootprintGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.RestoreFootprint
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.RestoreFootprint)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.RestoreFootprint), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(27, "restoreFootprintResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.OperationResult+trUnion+RestoreFootprint</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.RestoreFootprint> OperationResult_trUnion_RestoreFootprintMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.RestoreFootprint>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.RestoreFootprint>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
