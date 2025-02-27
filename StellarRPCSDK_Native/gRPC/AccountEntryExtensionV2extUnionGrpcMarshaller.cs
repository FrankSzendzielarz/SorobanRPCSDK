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
    /// <summary>Custom marshaller for Stellar.AccountEntryExtensionV2+extUnion</summary>
    public static class AccountEntryExtensionV2extUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static AccountEntryExtensionV2extUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AccountEntryExtensionV2.extUnion
            if (!model.IsDefined(typeof(Stellar.AccountEntryExtensionV2.extUnion)))
            {
                var metaType = model.Add(typeof(Stellar.AccountEntryExtensionV2.extUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.AccountEntryExtensionV2.extUnion.case_0));
                metaType.AddSubType(101, typeof(Stellar.AccountEntryExtensionV2.extUnion.case_3));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AccountEntryExtensionV2+extUnion</summary>
        public static readonly Marshaller<Stellar.AccountEntryExtensionV2.extUnion> AccountEntryExtensionV2_extUnionMarshaller = Marshallers.Create<Stellar.AccountEntryExtensionV2.extUnion>(
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
                        return Serializer.Deserialize<Stellar.AccountEntryExtensionV2.extUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
