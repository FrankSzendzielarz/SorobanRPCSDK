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
    /// <summary>Custom marshaller for Stellar.StellarMessage+FloodDemandCase</summary>
    public static class StellarMessageFloodDemandCaseGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarMessageFloodDemandCaseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarMessage.FloodDemandCase
            if (!model.IsDefined(typeof(Stellar.StellarMessage.FloodDemandCase)))
            {
                var metaType = model.Add(typeof(Stellar.StellarMessage.FloodDemandCase), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(23, "floodDemand");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for FloodDemandCase</summary>
        public static readonly Marshaller<Stellar.StellarMessage.FloodDemandCase> FloodDemandCaseMarshaller = Marshallers.Create<Stellar.StellarMessage.FloodDemandCase>(
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
                        return Serializer.Deserialize<Stellar.StellarMessage.FloodDemandCase>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
