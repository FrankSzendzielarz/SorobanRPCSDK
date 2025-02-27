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
    /// <summary>Custom marshaller for Stellar.TxSetComponentType</summary>
    public static class TxSetComponentTypeGrpcMarshaller
    {
        // Static constructor to configure type
        static TxSetComponentTypeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TxSetComponentType
            if (!model.IsDefined(typeof(Stellar.TxSetComponentType)))
            {
                var metaType = model.Add(typeof(Stellar.TxSetComponentType), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TxSetComponentType</summary>
        public static readonly Marshaller<Stellar.TxSetComponentType> TxSetComponentTypeMarshaller = Marshallers.Create<Stellar.TxSetComponentType>(
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
                        return Serializer.Deserialize<Stellar.TxSetComponentType>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
