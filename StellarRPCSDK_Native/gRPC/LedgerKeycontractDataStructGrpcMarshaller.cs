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
    /// <summary>Custom marshaller for Stellar.LedgerKey+contractDataStruct</summary>
    public static class LedgerKeycontractDataStructGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeycontractDataStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.contractDataStruct
            if (!model.IsDefined(typeof(Stellar.LedgerKey.contractDataStruct)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.contractDataStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "contract");
                metaType.Add(2, "key");
                metaType.Add(3, "durability");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerKey+contractDataStruct</summary>
        public static readonly Marshaller<Stellar.LedgerKey.contractDataStruct> LedgerKey_contractDataStructMarshaller = Marshallers.Create<Stellar.LedgerKey.contractDataStruct>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.contractDataStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
