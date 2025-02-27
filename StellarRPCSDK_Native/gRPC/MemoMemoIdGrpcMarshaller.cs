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
    /// <summary>Custom marshaller for Stellar.Memo+MemoId</summary>
    public static class MemoMemoIdGrpcMarshaller
    {
        // Static constructor to configure type
        static MemoMemoIdGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Memo.MemoId
            if (!model.IsDefined(typeof(Stellar.Memo.MemoId)))
            {
                var metaType = model.Add(typeof(Stellar.Memo.MemoId), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "id");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for MemoId</summary>
        public static readonly Marshaller<Stellar.Memo.MemoId> MemoIdMarshaller = Marshallers.Create<Stellar.Memo.MemoId>(
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
                        return Serializer.Deserialize<Stellar.Memo.MemoId>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
