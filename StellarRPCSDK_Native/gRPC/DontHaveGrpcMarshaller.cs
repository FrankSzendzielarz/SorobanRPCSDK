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
    /// <summary>Custom marshaller for Stellar.DontHave</summary>
    public static class DontHaveGrpcMarshaller
    {
        // Static constructor to configure type
        static DontHaveGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.DontHave
            if (!model.IsDefined(typeof(Stellar.DontHave)))
            {
                var metaType = model.Add(typeof(Stellar.DontHave), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "type");
                metaType.Add(2, "reqHash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.DontHave</summary>
        public static readonly Marshaller<Stellar.DontHave> DontHaveMarshaller = Marshallers.Create<Stellar.DontHave>(
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
                        return Serializer.Deserialize<Stellar.DontHave>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
