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
    /// <summary>Custom marshaller for Stellar.Preconditions+PrecondV2</summary>
    public static class PreconditionsPrecondV2GrpcMarshaller
    {
        // Static constructor to configure type
        static PreconditionsPrecondV2GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Preconditions.PrecondV2
            if (!model.IsDefined(typeof(Stellar.Preconditions.PrecondV2)))
            {
                var metaType = model.Add(typeof(Stellar.Preconditions.PrecondV2), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "v2");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PrecondV2</summary>
        public static readonly Marshaller<Stellar.Preconditions.PrecondV2> PrecondV2Marshaller = Marshallers.Create<Stellar.Preconditions.PrecondV2>(
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
                        return Serializer.Deserialize<Stellar.Preconditions.PrecondV2>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
