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
    /// <summary>Custom marshaller for Stellar.Memo+MemoText</summary>
    public static class MemoMemoTextGrpcMarshaller
    {
        // Static constructor to configure type
        static MemoMemoTextGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Memo.MemoText
            if (!model.IsDefined(typeof(Stellar.Memo.MemoText)))
            {
                var metaType = model.Add(typeof(Stellar.Memo.MemoText), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "text");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Memo+MemoText</summary>
        public static readonly Marshaller<Stellar.Memo.MemoText> Memo_MemoTextMarshaller = Marshallers.Create<Stellar.Memo.MemoText>(
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
                        return Serializer.Deserialize<Stellar.Memo.MemoText>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
