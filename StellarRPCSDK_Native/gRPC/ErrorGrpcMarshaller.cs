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
    /// <summary>Custom marshaller for Stellar.Error</summary>
    public static class ErrorGrpcMarshaller
    {
        // Static constructor to configure type
        static ErrorGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Error
            if (!model.IsDefined(typeof(Stellar.Error)))
            {
                var metaType = model.Add(typeof(Stellar.Error), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "code");
                metaType.Add(2, "msg");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Error</summary>
        public static readonly Marshaller<Stellar.Error> ErrorMarshaller = Marshallers.Create<Stellar.Error>(
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
                        return Serializer.Deserialize<Stellar.Error>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
