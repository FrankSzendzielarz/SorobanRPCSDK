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
    /// <summary>Custom marshaller for Stellar.MuxedAccount_ProtoWrapper+BIP39SeedParam</summary>
    public static class MuxedAccount_ProtoWrapperBIP39SeedParamGrpcMarshaller
    {
        // Static constructor to configure type
        static MuxedAccount_ProtoWrapperBIP39SeedParamGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam
            if (!model.IsDefined(typeof(Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam)))
            {
                var metaType = model.Add(typeof(Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Seed");
                metaType.Add(2, "AccountIndex");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.MuxedAccount_ProtoWrapper+BIP39SeedParam</summary>
        public static readonly Marshaller<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam> MuxedAccount_ProtoWrapper_BIP39SeedParamMarshaller = Marshallers.Create<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam>(
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
                        return Serializer.Deserialize<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
