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
    /// <summary>Custom marshaller for Stellar.AccountEntry</summary>
    public static class AccountEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static AccountEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AccountEntry
            if (!model.IsDefined(typeof(Stellar.AccountEntry)))
            {
                var metaType = model.Add(typeof(Stellar.AccountEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "accountID");
                metaType.Add(2, "balance");
                metaType.Add(3, "seqNum");
                metaType.Add(4, "numSubEntries");
                metaType.Add(5, "inflationDest");
                metaType.Add(6, "flags");
                metaType.Add(7, "homeDomain");
                metaType.Add(8, "thresholds");
                metaType.Add(9, "signers");
                metaType.Add(10, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AccountEntry</summary>
        public static readonly Marshaller<Stellar.AccountEntry> AccountEntryMarshaller = Marshallers.Create<Stellar.AccountEntry>(
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
                        return Serializer.Deserialize<Stellar.AccountEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
