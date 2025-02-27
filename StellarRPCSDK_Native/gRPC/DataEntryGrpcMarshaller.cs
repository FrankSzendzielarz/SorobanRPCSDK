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
    /// <summary>Custom marshaller for Stellar.DataEntry</summary>
    public static class DataEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static DataEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.DataEntry
            if (!model.IsDefined(typeof(Stellar.DataEntry)))
            {
                var metaType = model.Add(typeof(Stellar.DataEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "accountID");
                metaType.Add(2, "dataName");
                metaType.Add(3, "dataValue");
                metaType.Add(4, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for DataEntry</summary>
        public static readonly Marshaller<Stellar.DataEntry> DataEntryMarshaller = Marshallers.Create<Stellar.DataEntry>(
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
                        return Serializer.Deserialize<Stellar.DataEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
