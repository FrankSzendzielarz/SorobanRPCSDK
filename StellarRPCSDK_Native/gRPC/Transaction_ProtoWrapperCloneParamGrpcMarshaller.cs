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
    /// <summary>Custom marshaller for Stellar.Transaction_ProtoWrapper+CloneParam</summary>
    public static class Transaction_ProtoWrapperCloneParamGrpcMarshaller
    {
        // Static constructor to configure type
        static Transaction_ProtoWrapperCloneParamGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Transaction_ProtoWrapper.CloneParam
            if (!model.IsDefined(typeof(Stellar.Transaction_ProtoWrapper.CloneParam)))
            {
                var metaType = model.Add(typeof(Stellar.Transaction_ProtoWrapper.CloneParam), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Transaction");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Transaction_ProtoWrapper+CloneParam</summary>
        public static readonly Marshaller<Stellar.Transaction_ProtoWrapper.CloneParam> Transaction_ProtoWrapper_CloneParamMarshaller = Marshallers.Create<Stellar.Transaction_ProtoWrapper.CloneParam>(
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
                        return Serializer.Deserialize<Stellar.Transaction_ProtoWrapper.CloneParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
