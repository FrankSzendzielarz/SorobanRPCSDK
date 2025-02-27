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
    /// <summary>Custom marshaller for Stellar.DataValue</summary>
    public static class DataValueGrpcMarshaller
    {
        // Static constructor to configure type
        static DataValueGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.DataValue
            if (!model.IsDefined(typeof(Stellar.DataValue)))
            {
                var metaType = model.Add(typeof(Stellar.DataValue), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "InnerValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.DataValue</summary>
        public static readonly Marshaller<Stellar.DataValue> DataValueMarshaller = Marshallers.Create<Stellar.DataValue>(
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
                        return Serializer.Deserialize<Stellar.DataValue>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
