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
    /// <summary>Custom marshaller for Stellar.GeneralizedTransactionSet</summary>
    public static class GeneralizedTransactionSetGrpcMarshaller
    {
        // Static constructor to configure type
        static GeneralizedTransactionSetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.GeneralizedTransactionSet
            if (!model.IsDefined(typeof(Stellar.GeneralizedTransactionSet)))
            {
                var metaType = model.Add(typeof(Stellar.GeneralizedTransactionSet), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.GeneralizedTransactionSet.case_1));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for GeneralizedTransactionSet</summary>
        public static readonly Marshaller<Stellar.GeneralizedTransactionSet> GeneralizedTransactionSetMarshaller = Marshallers.Create<Stellar.GeneralizedTransactionSet>(
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
                        return Serializer.Deserialize<Stellar.GeneralizedTransactionSet>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
