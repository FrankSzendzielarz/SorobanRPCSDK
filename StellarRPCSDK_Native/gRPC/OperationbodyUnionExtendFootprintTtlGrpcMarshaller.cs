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
    /// <summary>Custom marshaller for Stellar.Operation+bodyUnion+ExtendFootprintTtl</summary>
    public static class OperationbodyUnionExtendFootprintTtlGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationbodyUnionExtendFootprintTtlGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Operation.bodyUnion.ExtendFootprintTtl
            if (!model.IsDefined(typeof(Stellar.Operation.bodyUnion.ExtendFootprintTtl)))
            {
                var metaType = model.Add(typeof(Stellar.Operation.bodyUnion.ExtendFootprintTtl), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(24, "extendFootprintTTLOp");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ExtendFootprintTtl</summary>
        public static readonly Marshaller<Stellar.Operation.bodyUnion.ExtendFootprintTtl> ExtendFootprintTtlMarshaller = Marshallers.Create<Stellar.Operation.bodyUnion.ExtendFootprintTtl>(
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
                        return Serializer.Deserialize<Stellar.Operation.bodyUnion.ExtendFootprintTtl>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
