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
    /// <summary>Custom marshaller for Stellar.Preconditions+PrecondTime</summary>
    public static class PreconditionsPrecondTimeGrpcMarshaller
    {
        // Static constructor to configure type
        static PreconditionsPrecondTimeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Preconditions.PrecondTime
            if (!model.IsDefined(typeof(Stellar.Preconditions.PrecondTime)))
            {
                var metaType = model.Add(typeof(Stellar.Preconditions.PrecondTime), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "timeBounds");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Preconditions+PrecondTime</summary>
        public static readonly Marshaller<Stellar.Preconditions.PrecondTime> Preconditions_PrecondTimeMarshaller = Marshallers.Create<Stellar.Preconditions.PrecondTime>(
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
                        return Serializer.Deserialize<Stellar.Preconditions.PrecondTime>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
