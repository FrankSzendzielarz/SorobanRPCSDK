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
    /// <summary>Custom marshaller for Stellar.Memo+MemoNone</summary>
    public static class MemoMemoNoneGrpcMarshaller
    {
        // Static constructor to configure type
        static MemoMemoNoneGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Memo.MemoNone
            if (!model.IsDefined(typeof(Stellar.Memo.MemoNone)))
            {
                var metaType = model.Add(typeof(Stellar.Memo.MemoNone), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Memo+MemoNone</summary>
        public static readonly Marshaller<Stellar.Memo.MemoNone> Memo_MemoNoneMarshaller = Marshallers.Create<Stellar.Memo.MemoNone>(
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
                        return Serializer.Deserialize<Stellar.Memo.MemoNone>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
