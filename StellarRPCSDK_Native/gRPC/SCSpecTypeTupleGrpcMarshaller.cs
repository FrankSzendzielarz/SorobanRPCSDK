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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeTuple</summary>
    public static class SCSpecTypeTupleGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeTupleGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeTuple
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeTuple)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeTuple), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "valueTypes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecTypeTuple</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeTuple> SCSpecTypeTupleMarshaller = Marshallers.Create<Stellar.SCSpecTypeTuple>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeTuple>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
