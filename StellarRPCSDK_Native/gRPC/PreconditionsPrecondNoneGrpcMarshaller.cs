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
    /// <summary>Custom marshaller for Stellar.Preconditions+PrecondNone</summary>
    public static class PreconditionsPrecondNoneGrpcMarshaller
    {
        // Static constructor to configure type
        static PreconditionsPrecondNoneGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Preconditions.PrecondNone
            if (!model.IsDefined(typeof(Stellar.Preconditions.PrecondNone)))
            {
                var metaType = model.Add(typeof(Stellar.Preconditions.PrecondNone), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PrecondNone</summary>
        public static readonly Marshaller<Stellar.Preconditions.PrecondNone> PrecondNoneMarshaller = Marshallers.Create<Stellar.Preconditions.PrecondNone>(
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
                        return Serializer.Deserialize<Stellar.Preconditions.PrecondNone>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
