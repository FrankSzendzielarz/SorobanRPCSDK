// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.GetLedgerEntriesResult</summary>
    public static class GetLedgerEntriesResultGrpcMarshaller
    {
        // Static constructor to configure type
        static GetLedgerEntriesResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetLedgerEntriesResult
            if (!model.IsDefined(typeof(Stellar.RPC.GetLedgerEntriesResult)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetLedgerEntriesResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "LatestLedger");
                metaType.Add(2, "Entries");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for GetLedgerEntriesResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetLedgerEntriesResult> GetLedgerEntriesResultMarshaller = Marshallers.Create<Stellar.RPC.GetLedgerEntriesResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetLedgerEntriesResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
