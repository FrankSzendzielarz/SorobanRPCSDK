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
    /// <summary>Custom marshaller for Stellar.BumpSequenceResult+BumpSequenceBadSeq</summary>
    public static class BumpSequenceResultBumpSequenceBadSeqGrpcMarshaller
    {
        // Static constructor to configure type
        static BumpSequenceResultBumpSequenceBadSeqGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BumpSequenceResult.BumpSequenceBadSeq
            if (!model.IsDefined(typeof(Stellar.BumpSequenceResult.BumpSequenceBadSeq)))
            {
                var metaType = model.Add(typeof(Stellar.BumpSequenceResult.BumpSequenceBadSeq), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for BumpSequenceBadSeq</summary>
        public static readonly Marshaller<Stellar.BumpSequenceResult.BumpSequenceBadSeq> BumpSequenceBadSeqMarshaller = Marshallers.Create<Stellar.BumpSequenceResult.BumpSequenceBadSeq>(
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
                        return Serializer.Deserialize<Stellar.BumpSequenceResult.BumpSequenceBadSeq>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
