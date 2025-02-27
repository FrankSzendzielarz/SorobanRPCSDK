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
    /// <summary>Custom marshaller for Stellar.InflationResult</summary>
    public static class InflationResultGrpcMarshaller
    {
        // Static constructor to configure type
        static InflationResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InflationResult
            if (!model.IsDefined(typeof(Stellar.InflationResult)))
            {
                var metaType = model.Add(typeof(Stellar.InflationResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.InflationResult.InflationSuccess));
                metaType.AddSubType(101, typeof(Stellar.InflationResult.InflationNotTime));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for InflationResult</summary>
        public static readonly Marshaller<Stellar.InflationResult> InflationResultMarshaller = Marshallers.Create<Stellar.InflationResult>(
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
                        return Serializer.Deserialize<Stellar.InflationResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
