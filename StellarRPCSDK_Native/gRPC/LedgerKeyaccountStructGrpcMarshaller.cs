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
    /// <summary>Custom marshaller for Stellar.LedgerKey+accountStruct</summary>
    public static class LedgerKeyaccountStructGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyaccountStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.accountStruct
            if (!model.IsDefined(typeof(Stellar.LedgerKey.accountStruct)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.accountStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "accountID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for accountStruct</summary>
        public static readonly Marshaller<Stellar.LedgerKey.accountStruct> accountStructMarshaller = Marshallers.Create<Stellar.LedgerKey.accountStruct>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.accountStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
