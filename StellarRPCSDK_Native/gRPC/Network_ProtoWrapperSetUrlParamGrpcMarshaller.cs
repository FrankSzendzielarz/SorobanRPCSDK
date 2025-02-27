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
    /// <summary>Custom marshaller for Stellar.Network_ProtoWrapper+SetUrlParam</summary>
    public static class Network_ProtoWrapperSetUrlParamGrpcMarshaller
    {
        // Static constructor to configure type
        static Network_ProtoWrapperSetUrlParamGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Network_ProtoWrapper.SetUrlParam
            if (!model.IsDefined(typeof(Stellar.Network_ProtoWrapper.SetUrlParam)))
            {
                var metaType = model.Add(typeof(Stellar.Network_ProtoWrapper.SetUrlParam), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Url");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetUrlParam</summary>
        public static readonly Marshaller<Stellar.Network_ProtoWrapper.SetUrlParam> SetUrlParamMarshaller = Marshallers.Create<Stellar.Network_ProtoWrapper.SetUrlParam>(
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
                        return Serializer.Deserialize<Stellar.Network_ProtoWrapper.SetUrlParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
