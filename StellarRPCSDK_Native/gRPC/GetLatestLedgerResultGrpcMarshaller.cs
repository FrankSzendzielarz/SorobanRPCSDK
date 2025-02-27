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
    /// <summary>Custom marshaller for Stellar.RPC.GetLatestLedgerResult</summary>
    public static class GetLatestLedgerResultGrpcMarshaller
    {
        // Static constructor to configure type
        static GetLatestLedgerResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetLatestLedgerResult
            if (!model.IsDefined(typeof(Stellar.RPC.GetLatestLedgerResult)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetLatestLedgerResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Id");
                metaType.Add(2, "ProtocolVersion");
                metaType.Add(3, "Sequence");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.GetLatestLedgerResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetLatestLedgerResult> GetLatestLedgerResultMarshaller = Marshallers.Create<Stellar.RPC.GetLatestLedgerResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetLatestLedgerResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
