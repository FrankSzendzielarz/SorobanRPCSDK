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
    /// <summary>Custom marshaller for Stellar.RPC.GetHealthResult</summary>
    public static class GetHealthResultGrpcMarshaller
    {
        // Static constructor to configure type
        static GetHealthResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetHealthResult
            if (!model.IsDefined(typeof(Stellar.RPC.GetHealthResult)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetHealthResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Status");
                metaType.Add(2, "LatestLedger");
                metaType.Add(3, "OldestLedger");
                metaType.Add(4, "LedgerRetentionWindow");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.GetHealthResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetHealthResult> GetHealthResultMarshaller = Marshallers.Create<Stellar.RPC.GetHealthResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetHealthResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
