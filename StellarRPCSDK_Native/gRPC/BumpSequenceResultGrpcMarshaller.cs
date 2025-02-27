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
    /// <summary>Custom marshaller for Stellar.BumpSequenceResult</summary>
    public static class BumpSequenceResultGrpcMarshaller
    {
        // Static constructor to configure type
        static BumpSequenceResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BumpSequenceResult
            if (!model.IsDefined(typeof(Stellar.BumpSequenceResult)))
            {
                var metaType = model.Add(typeof(Stellar.BumpSequenceResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.BumpSequenceResult.BumpSequenceSuccess));
                metaType.AddSubType(101, typeof(Stellar.BumpSequenceResult.BumpSequenceBadSeq));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.BumpSequenceResult</summary>
        public static readonly Marshaller<Stellar.BumpSequenceResult> BumpSequenceResultMarshaller = Marshallers.Create<Stellar.BumpSequenceResult>(
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
                        return Serializer.Deserialize<Stellar.BumpSequenceResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
