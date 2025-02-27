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
    /// <summary>Custom marshaller for Stellar.RestoreFootprintResult</summary>
    public static class RestoreFootprintResultGrpcMarshaller
    {
        // Static constructor to configure type
        static RestoreFootprintResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RestoreFootprintResult
            if (!model.IsDefined(typeof(Stellar.RestoreFootprintResult)))
            {
                var metaType = model.Add(typeof(Stellar.RestoreFootprintResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.RestoreFootprintResult.RestoreFootprintSuccess));
                metaType.AddSubType(101, typeof(Stellar.RestoreFootprintResult.RestoreFootprintMalformed));
                metaType.AddSubType(102, typeof(Stellar.RestoreFootprintResult.RestoreFootprintResourceLimitExceeded));
                metaType.AddSubType(103, typeof(Stellar.RestoreFootprintResult.RestoreFootprintInsufficientRefundableFee));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for RestoreFootprintResult</summary>
        public static readonly Marshaller<Stellar.RestoreFootprintResult> RestoreFootprintResultMarshaller = Marshallers.Create<Stellar.RestoreFootprintResult>(
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
                        return Serializer.Deserialize<Stellar.RestoreFootprintResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
