// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Google.Protobuf.WellKnownTypes;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Google.Protobuf.WellKnownTypes.Empty</summary>
    public static class EmptyGrpcMarshaller
    {
        // Static constructor to configure type
        static EmptyGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model
            var model = RuntimeTypeModel.Default;

            // Configure Google.Protobuf.WellKnownTypes.Empty
            if (!model.IsDefined(typeof(Google.Protobuf.WellKnownTypes.Empty)))
            {
                model.Add(typeof(Google.Protobuf.WellKnownTypes.Empty), true);
            }
        }

        /// <summary>Marshaller for Empty</summary>
        public static readonly Marshaller<Google.Protobuf.WellKnownTypes.Empty> EmptyMarshaller = Marshallers.Create<Google.Protobuf.WellKnownTypes.Empty>(
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
                        return Serializer.Deserialize<Google.Protobuf.WellKnownTypes.Empty>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
