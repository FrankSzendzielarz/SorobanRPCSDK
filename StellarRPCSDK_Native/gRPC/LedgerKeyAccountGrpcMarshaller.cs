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
    /// <summary>Custom marshaller for Stellar.LedgerKey+Account</summary>
    public static class LedgerKeyAccountGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyAccountGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.Account
            if (!model.IsDefined(typeof(Stellar.LedgerKey.Account)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.Account), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "account");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Account</summary>
        public static readonly Marshaller<Stellar.LedgerKey.Account> AccountMarshaller = Marshallers.Create<Stellar.LedgerKey.Account>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.Account>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
