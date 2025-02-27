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
    /// <summary>Custom marshaller for Stellar.MuxedAccount_ProtoWrapper+VerifyMessage</summary>
    public static class MuxedAccount_ProtoWrapperVerifyMessageGrpcMarshaller
    {
        // Static constructor to configure type
        static MuxedAccount_ProtoWrapperVerifyMessageGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.MuxedAccount_ProtoWrapper.VerifyMessage
            if (!model.IsDefined(typeof(Stellar.MuxedAccount_ProtoWrapper.VerifyMessage)))
            {
                var metaType = model.Add(typeof(Stellar.MuxedAccount_ProtoWrapper.VerifyMessage), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Account");
                metaType.Add(2, "Data");
                metaType.Add(3, "Signature");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.MuxedAccount_ProtoWrapper+VerifyMessage</summary>
        public static readonly Marshaller<Stellar.MuxedAccount_ProtoWrapper.VerifyMessage> MuxedAccount_ProtoWrapper_VerifyMessageMarshaller = Marshallers.Create<Stellar.MuxedAccount_ProtoWrapper.VerifyMessage>(
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
                        return Serializer.Deserialize<Stellar.MuxedAccount_ProtoWrapper.VerifyMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
