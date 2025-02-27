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
    /// <summary>Custom marshaller for Stellar.Memo+MemoReturn</summary>
    public static class MemoMemoReturnGrpcMarshaller
    {
        // Static constructor to configure type
        static MemoMemoReturnGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Memo.MemoReturn
            if (!model.IsDefined(typeof(Stellar.Memo.MemoReturn)))
            {
                var metaType = model.Add(typeof(Stellar.Memo.MemoReturn), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "retHash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Memo+MemoReturn</summary>
        public static readonly Marshaller<Stellar.Memo.MemoReturn> Memo_MemoReturnMarshaller = Marshallers.Create<Stellar.Memo.MemoReturn>(
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
                        return Serializer.Deserialize<Stellar.Memo.MemoReturn>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
