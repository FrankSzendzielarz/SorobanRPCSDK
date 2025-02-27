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
    /// <summary>Custom marshaller for Stellar.InflationResult+InflationSuccess</summary>
    public static class InflationResultInflationSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static InflationResultInflationSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InflationResult.InflationSuccess
            if (!model.IsDefined(typeof(Stellar.InflationResult.InflationSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.InflationResult.InflationSuccess), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "payouts");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for InflationSuccess</summary>
        public static readonly Marshaller<Stellar.InflationResult.InflationSuccess> InflationSuccessMarshaller = Marshallers.Create<Stellar.InflationResult.InflationSuccess>(
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
                        return Serializer.Deserialize<Stellar.InflationResult.InflationSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
