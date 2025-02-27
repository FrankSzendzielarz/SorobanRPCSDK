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
    /// <summary>Custom marshaller for Stellar.Transaction_ProtoWrapper+SignParam</summary>
    public static class Transaction_ProtoWrapperSignParamGrpcMarshaller
    {
        // Static constructor to configure type
        static Transaction_ProtoWrapperSignParamGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Transaction_ProtoWrapper.SignParam
            if (!model.IsDefined(typeof(Stellar.Transaction_ProtoWrapper.SignParam)))
            {
                var metaType = model.Add(typeof(Stellar.Transaction_ProtoWrapper.SignParam), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Transaction");
                metaType.Add(2, "Account");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Transaction_ProtoWrapper+SignParam</summary>
        public static readonly Marshaller<Stellar.Transaction_ProtoWrapper.SignParam> Transaction_ProtoWrapper_SignParamMarshaller = Marshallers.Create<Stellar.Transaction_ProtoWrapper.SignParam>(
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
                        return Serializer.Deserialize<Stellar.Transaction_ProtoWrapper.SignParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
