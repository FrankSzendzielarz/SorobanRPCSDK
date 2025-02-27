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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeVec</summary>
    public static class SCSpecTypeVecGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeVecGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeVec
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeVec)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeVec), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "elementType");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecTypeVec</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeVec> SCSpecTypeVecMarshaller = Marshallers.Create<Stellar.SCSpecTypeVec>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeVec>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
