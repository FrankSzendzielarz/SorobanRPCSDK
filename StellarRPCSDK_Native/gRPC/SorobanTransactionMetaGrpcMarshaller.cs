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
    /// <summary>Custom marshaller for Stellar.SorobanTransactionMeta</summary>
    public static class SorobanTransactionMetaGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanTransactionMetaGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanTransactionMeta
            if (!model.IsDefined(typeof(Stellar.SorobanTransactionMeta)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanTransactionMeta), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "events");
                metaType.Add(3, "returnValue");
                metaType.Add(4, "diagnosticEvents");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanTransactionMeta</summary>
        public static readonly Marshaller<Stellar.SorobanTransactionMeta> SorobanTransactionMetaMarshaller = Marshallers.Create<Stellar.SorobanTransactionMeta>(
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
                        return Serializer.Deserialize<Stellar.SorobanTransactionMeta>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
