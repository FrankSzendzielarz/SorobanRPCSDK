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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeOption</summary>
    public static class SCSpecTypeOptionGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeOptionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeOption
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeOption)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeOption), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "valueType");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecTypeOption</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeOption> SCSpecTypeOptionMarshaller = Marshallers.Create<Stellar.SCSpecTypeOption>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeOption>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
