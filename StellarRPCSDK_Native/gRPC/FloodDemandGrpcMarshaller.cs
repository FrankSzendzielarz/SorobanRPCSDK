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
    /// <summary>Custom marshaller for Stellar.FloodDemand</summary>
    public static class FloodDemandGrpcMarshaller
    {
        // Static constructor to configure type
        static FloodDemandGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.FloodDemand
            if (!model.IsDefined(typeof(Stellar.FloodDemand)))
            {
                var metaType = model.Add(typeof(Stellar.FloodDemand), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "txHashes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for FloodDemand</summary>
        public static readonly Marshaller<Stellar.FloodDemand> FloodDemandMarshaller = Marshallers.Create<Stellar.FloodDemand>(
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
                        return Serializer.Deserialize<Stellar.FloodDemand>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
