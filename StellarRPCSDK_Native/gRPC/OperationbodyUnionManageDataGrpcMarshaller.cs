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
    /// <summary>Custom marshaller for Stellar.Operation+bodyUnion+ManageData</summary>
    public static class OperationbodyUnionManageDataGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationbodyUnionManageDataGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Operation.bodyUnion.ManageData
            if (!model.IsDefined(typeof(Stellar.Operation.bodyUnion.ManageData)))
            {
                var metaType = model.Add(typeof(Stellar.Operation.bodyUnion.ManageData), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(10, "manageDataOp");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageData</summary>
        public static readonly Marshaller<Stellar.Operation.bodyUnion.ManageData> ManageDataMarshaller = Marshallers.Create<Stellar.Operation.bodyUnion.ManageData>(
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
                        return Serializer.Deserialize<Stellar.Operation.bodyUnion.ManageData>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
