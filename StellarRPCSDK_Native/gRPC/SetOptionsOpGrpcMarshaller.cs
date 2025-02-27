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
    /// <summary>Custom marshaller for Stellar.SetOptionsOp</summary>
    public static class SetOptionsOpGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsOp
            if (!model.IsDefined(typeof(Stellar.SetOptionsOp)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "inflationDest");
                metaType.Add(2, "clearFlags");
                metaType.Add(3, "setFlags");
                metaType.Add(4, "masterWeight");
                metaType.Add(5, "lowThreshold");
                metaType.Add(6, "medThreshold");
                metaType.Add(7, "highThreshold");
                metaType.Add(8, "homeDomain");
                metaType.Add(9, "signer");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetOptionsOp</summary>
        public static readonly Marshaller<Stellar.SetOptionsOp> SetOptionsOpMarshaller = Marshallers.Create<Stellar.SetOptionsOp>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
