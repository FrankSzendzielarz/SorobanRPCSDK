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
    /// <summary>Custom marshaller for Stellar.LedgerKey+configSettingStruct</summary>
    public static class LedgerKeyconfigSettingStructGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyconfigSettingStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.configSettingStruct
            if (!model.IsDefined(typeof(Stellar.LedgerKey.configSettingStruct)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.configSettingStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "configSettingID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerKey+configSettingStruct</summary>
        public static readonly Marshaller<Stellar.LedgerKey.configSettingStruct> LedgerKey_configSettingStructMarshaller = Marshallers.Create<Stellar.LedgerKey.configSettingStruct>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.configSettingStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
