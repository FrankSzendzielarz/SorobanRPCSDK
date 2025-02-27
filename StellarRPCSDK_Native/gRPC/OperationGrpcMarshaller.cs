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
    /// <summary>Custom marshaller for Stellar.Operation</summary>
    public static class OperationGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Operation
            if (!model.IsDefined(typeof(Stellar.Operation)))
            {
                var metaType = model.Add(typeof(Stellar.Operation), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sourceAccount");
                metaType.Add(2, "body");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Operation</summary>
        public static readonly Marshaller<Stellar.Operation> OperationMarshaller = Marshallers.Create<Stellar.Operation>(
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
                        return Serializer.Deserialize<Stellar.Operation>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
