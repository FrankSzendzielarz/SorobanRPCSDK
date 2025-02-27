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
    /// <summary>Custom marshaller for Stellar.Memo</summary>
    public static class MemoGrpcMarshaller
    {
        // Static constructor to configure type
        static MemoGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Memo
            if (!model.IsDefined(typeof(Stellar.Memo)))
            {
                var metaType = model.Add(typeof(Stellar.Memo), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.Memo.MemoNone));
                metaType.AddSubType(101, typeof(Stellar.Memo.MemoText));
                metaType.AddSubType(102, typeof(Stellar.Memo.MemoId));
                metaType.AddSubType(103, typeof(Stellar.Memo.MemoHash));
                metaType.AddSubType(104, typeof(Stellar.Memo.MemoReturn));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Memo</summary>
        public static readonly Marshaller<Stellar.Memo> MemoMarshaller = Marshallers.Create<Stellar.Memo>(
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
                        return Serializer.Deserialize<Stellar.Memo>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
