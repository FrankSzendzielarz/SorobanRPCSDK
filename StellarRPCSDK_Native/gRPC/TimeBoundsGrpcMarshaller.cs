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
    /// <summary>Custom marshaller for Stellar.TimeBounds</summary>
    public static class TimeBoundsGrpcMarshaller
    {
        // Static constructor to configure type
        static TimeBoundsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TimeBounds
            if (!model.IsDefined(typeof(Stellar.TimeBounds)))
            {
                var metaType = model.Add(typeof(Stellar.TimeBounds), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "minTime");
                metaType.Add(2, "maxTime");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TimeBounds</summary>
        public static readonly Marshaller<Stellar.TimeBounds> TimeBoundsMarshaller = Marshallers.Create<Stellar.TimeBounds>(
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
                        return Serializer.Deserialize<Stellar.TimeBounds>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
