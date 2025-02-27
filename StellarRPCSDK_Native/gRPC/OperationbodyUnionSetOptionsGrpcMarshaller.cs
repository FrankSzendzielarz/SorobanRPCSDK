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
    /// <summary>Custom marshaller for Stellar.Operation+bodyUnion+SetOptions</summary>
    public static class OperationbodyUnionSetOptionsGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationbodyUnionSetOptionsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Operation.bodyUnion.SetOptions
            if (!model.IsDefined(typeof(Stellar.Operation.bodyUnion.SetOptions)))
            {
                var metaType = model.Add(typeof(Stellar.Operation.bodyUnion.SetOptions), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(6, "setOptionsOp");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Operation+bodyUnion+SetOptions</summary>
        public static readonly Marshaller<Stellar.Operation.bodyUnion.SetOptions> Operation_bodyUnion_SetOptionsMarshaller = Marshallers.Create<Stellar.Operation.bodyUnion.SetOptions>(
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
                        return Serializer.Deserialize<Stellar.Operation.bodyUnion.SetOptions>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
