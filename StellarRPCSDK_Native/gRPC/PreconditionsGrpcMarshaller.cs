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
    /// <summary>Custom marshaller for Stellar.Preconditions</summary>
    public static class PreconditionsGrpcMarshaller
    {
        // Static constructor to configure type
        static PreconditionsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Preconditions
            if (!model.IsDefined(typeof(Stellar.Preconditions)))
            {
                var metaType = model.Add(typeof(Stellar.Preconditions), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.Preconditions.PrecondNone));
                metaType.AddSubType(101, typeof(Stellar.Preconditions.PrecondTime));
                metaType.AddSubType(102, typeof(Stellar.Preconditions.PrecondV2));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Preconditions</summary>
        public static readonly Marshaller<Stellar.Preconditions> PreconditionsMarshaller = Marshallers.Create<Stellar.Preconditions>(
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
                        return Serializer.Deserialize<Stellar.Preconditions>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
