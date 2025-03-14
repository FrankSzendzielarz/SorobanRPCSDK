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
    /// <summary>Custom marshaller for Stellar.LedgerKey+contractCodeStruct</summary>
    public static class LedgerKeycontractCodeStructGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeycontractCodeStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.contractCodeStruct
            if (!model.IsDefined(typeof(Stellar.LedgerKey.contractCodeStruct)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.contractCodeStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "hash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerKey+contractCodeStruct</summary>
        public static readonly Marshaller<Stellar.LedgerKey.contractCodeStruct> LedgerKey_contractCodeStructMarshaller = Marshallers.Create<Stellar.LedgerKey.contractCodeStruct>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.contractCodeStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
