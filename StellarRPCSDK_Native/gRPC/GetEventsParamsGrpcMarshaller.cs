// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.GetEventsParams</summary>
    public static class GetEventsParamsGrpcMarshaller
    {
        // Static constructor to configure type
        static GetEventsParamsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetEventsParams
            if (!model.IsDefined(typeof(Stellar.RPC.GetEventsParams)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetEventsParams), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "StartLedger");
                metaType.Add(2, "Filters");
                metaType.Add(3, "Pagination");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for GetEventsParams</summary>
        public static readonly Marshaller<Stellar.RPC.GetEventsParams> GetEventsParamsMarshaller = Marshallers.Create<Stellar.RPC.GetEventsParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetEventsParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
