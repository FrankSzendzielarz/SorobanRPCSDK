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
    /// <summary>Custom marshaller for Stellar.ExtendFootprintTTLResult</summary>
    public static class ExtendFootprintTTLResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ExtendFootprintTTLResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ExtendFootprintTTLResult
            if (!model.IsDefined(typeof(Stellar.ExtendFootprintTTLResult)))
            {
                var metaType = model.Add(typeof(Stellar.ExtendFootprintTTLResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlSuccess));
                metaType.AddSubType(101, typeof(Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlMalformed));
                metaType.AddSubType(102, typeof(Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlResourceLimitExceeded));
                metaType.AddSubType(103, typeof(Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlInsufficientRefundableFee));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ExtendFootprintTTLResult</summary>
        public static readonly Marshaller<Stellar.ExtendFootprintTTLResult> ExtendFootprintTTLResultMarshaller = Marshallers.Create<Stellar.ExtendFootprintTTLResult>(
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
                        return Serializer.Deserialize<Stellar.ExtendFootprintTTLResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
