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
    /// <summary>Custom marshaller for Stellar.LedgerEntry+dataUnion+Account</summary>
    public static class LedgerEntrydataUnionAccountGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntrydataUnionAccountGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntry.dataUnion.Account
            if (!model.IsDefined(typeof(Stellar.LedgerEntry.dataUnion.Account)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntry.dataUnion.Account), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "account");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerEntry+dataUnion+Account</summary>
        public static readonly Marshaller<Stellar.LedgerEntry.dataUnion.Account> LedgerEntry_dataUnion_AccountMarshaller = Marshallers.Create<Stellar.LedgerEntry.dataUnion.Account>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntry.dataUnion.Account>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
