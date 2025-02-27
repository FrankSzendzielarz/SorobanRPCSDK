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
    /// <summary>Custom marshaller for Stellar.ExtendFootprintTTLResult+ExtendFootprintTtlSuccess</summary>
    public static class ExtendFootprintTTLResultExtendFootprintTtlSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static ExtendFootprintTTLResultExtendFootprintTtlSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlSuccess
            if (!model.IsDefined(typeof(Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ExtendFootprintTtlSuccess</summary>
        public static readonly Marshaller<Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlSuccess> ExtendFootprintTtlSuccessMarshaller = Marshallers.Create<Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlSuccess>(
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
                        return Serializer.Deserialize<Stellar.ExtendFootprintTTLResult.ExtendFootprintTtlSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
