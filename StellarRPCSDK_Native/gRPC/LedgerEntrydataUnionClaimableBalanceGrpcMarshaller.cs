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
    /// <summary>Custom marshaller for Stellar.LedgerEntry+dataUnion+ClaimableBalance</summary>
    public static class LedgerEntrydataUnionClaimableBalanceGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerEntrydataUnionClaimableBalanceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerEntry.dataUnion.ClaimableBalance
            if (!model.IsDefined(typeof(Stellar.LedgerEntry.dataUnion.ClaimableBalance)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerEntry.dataUnion.ClaimableBalance), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(5, "claimableBalance");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimableBalance</summary>
        public static readonly Marshaller<Stellar.LedgerEntry.dataUnion.ClaimableBalance> ClaimableBalanceMarshaller = Marshallers.Create<Stellar.LedgerEntry.dataUnion.ClaimableBalance>(
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
                        return Serializer.Deserialize<Stellar.LedgerEntry.dataUnion.ClaimableBalance>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
