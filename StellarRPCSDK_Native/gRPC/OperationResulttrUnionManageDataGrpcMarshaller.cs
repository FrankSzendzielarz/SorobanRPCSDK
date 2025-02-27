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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+ManageData</summary>
    public static class OperationResulttrUnionManageDataGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionManageDataGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.ManageData
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.ManageData)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.ManageData), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(11, "manageDataResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageData</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.ManageData> ManageDataMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.ManageData>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.ManageData>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
