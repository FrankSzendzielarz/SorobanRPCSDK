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
    /// <summary>Custom marshaller for Stellar.RevokeSponsorshipOp+RevokeSponsorshipLedgerEntry</summary>
    public static class RevokeSponsorshipOpRevokeSponsorshipLedgerEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static RevokeSponsorshipOpRevokeSponsorshipLedgerEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RevokeSponsorshipOp.RevokeSponsorshipLedgerEntry
            if (!model.IsDefined(typeof(Stellar.RevokeSponsorshipOp.RevokeSponsorshipLedgerEntry)))
            {
                var metaType = model.Add(typeof(Stellar.RevokeSponsorshipOp.RevokeSponsorshipLedgerEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerKey");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RevokeSponsorshipOp+RevokeSponsorshipLedgerEntry</summary>
        public static readonly Marshaller<Stellar.RevokeSponsorshipOp.RevokeSponsorshipLedgerEntry> RevokeSponsorshipOp_RevokeSponsorshipLedgerEntryMarshaller = Marshallers.Create<Stellar.RevokeSponsorshipOp.RevokeSponsorshipLedgerEntry>(
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
                        return Serializer.Deserialize<Stellar.RevokeSponsorshipOp.RevokeSponsorshipLedgerEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
