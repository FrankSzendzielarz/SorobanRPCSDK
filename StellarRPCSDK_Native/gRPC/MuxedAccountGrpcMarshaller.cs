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
    /// <summary>Custom marshaller for Stellar.MuxedAccount</summary>
    public static class MuxedAccountGrpcMarshaller
    {
        // Static constructor to configure type
        static MuxedAccountGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.MuxedAccount
            if (!model.IsDefined(typeof(Stellar.MuxedAccount)))
            {
                var metaType = model.Add(typeof(Stellar.MuxedAccount), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.MuxedAccount.KeyTypeEd25519));
                metaType.AddSubType(101, typeof(Stellar.MuxedAccount.KeyTypeMuxedEd25519));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for MuxedAccount</summary>
        public static readonly Marshaller<Stellar.MuxedAccount> MuxedAccountMarshaller = Marshallers.Create<Stellar.MuxedAccount>(
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
                        return Serializer.Deserialize<Stellar.MuxedAccount>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
