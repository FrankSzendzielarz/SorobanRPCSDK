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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeMap</summary>
    public static class SCSpecTypeMapGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeMapGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeMap
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeMap)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeMap), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "keyType");
                metaType.Add(2, "valueType");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecTypeMap</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeMap> SCSpecTypeMapMarshaller = Marshallers.Create<Stellar.SCSpecTypeMap>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeMap>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
