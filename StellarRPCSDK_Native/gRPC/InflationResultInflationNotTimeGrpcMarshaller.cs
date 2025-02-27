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
    /// <summary>Custom marshaller for Stellar.InflationResult+InflationNotTime</summary>
    public static class InflationResultInflationNotTimeGrpcMarshaller
    {
        // Static constructor to configure type
        static InflationResultInflationNotTimeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InflationResult.InflationNotTime
            if (!model.IsDefined(typeof(Stellar.InflationResult.InflationNotTime)))
            {
                var metaType = model.Add(typeof(Stellar.InflationResult.InflationNotTime), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for InflationNotTime</summary>
        public static readonly Marshaller<Stellar.InflationResult.InflationNotTime> InflationNotTimeMarshaller = Marshallers.Create<Stellar.InflationResult.InflationNotTime>(
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
                        return Serializer.Deserialize<Stellar.InflationResult.InflationNotTime>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
