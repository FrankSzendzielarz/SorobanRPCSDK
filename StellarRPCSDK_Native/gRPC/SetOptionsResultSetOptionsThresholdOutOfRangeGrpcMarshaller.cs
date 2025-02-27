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
    /// <summary>Custom marshaller for Stellar.SetOptionsResult+SetOptionsThresholdOutOfRange</summary>
    public static class SetOptionsResultSetOptionsThresholdOutOfRangeGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsResultSetOptionsThresholdOutOfRangeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsResult.SetOptionsThresholdOutOfRange
            if (!model.IsDefined(typeof(Stellar.SetOptionsResult.SetOptionsThresholdOutOfRange)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsResult.SetOptionsThresholdOutOfRange), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SetOptionsResult+SetOptionsThresholdOutOfRange</summary>
        public static readonly Marshaller<Stellar.SetOptionsResult.SetOptionsThresholdOutOfRange> SetOptionsResult_SetOptionsThresholdOutOfRangeMarshaller = Marshallers.Create<Stellar.SetOptionsResult.SetOptionsThresholdOutOfRange>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsResult.SetOptionsThresholdOutOfRange>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
