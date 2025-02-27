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
    /// <summary>Custom marshaller for Stellar.LedgerCloseMeta+case_0</summary>
    public static class LedgerCloseMetacase_0GrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerCloseMetacase_0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerCloseMeta.case_0
            if (!model.IsDefined(typeof(Stellar.LedgerCloseMeta.case_0)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerCloseMeta.case_0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "v0");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for case_0</summary>
        public static readonly Marshaller<Stellar.LedgerCloseMeta.case_0> case_0Marshaller = Marshallers.Create<Stellar.LedgerCloseMeta.case_0>(
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
                        return Serializer.Deserialize<Stellar.LedgerCloseMeta.case_0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
