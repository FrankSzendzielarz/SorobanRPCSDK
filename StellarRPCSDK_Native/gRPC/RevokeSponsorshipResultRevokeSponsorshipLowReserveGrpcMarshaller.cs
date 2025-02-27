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
    /// <summary>Custom marshaller for Stellar.RevokeSponsorshipResult+RevokeSponsorshipLowReserve</summary>
    public static class RevokeSponsorshipResultRevokeSponsorshipLowReserveGrpcMarshaller
    {
        // Static constructor to configure type
        static RevokeSponsorshipResultRevokeSponsorshipLowReserveGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RevokeSponsorshipResult.RevokeSponsorshipLowReserve
            if (!model.IsDefined(typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipLowReserve)))
            {
                var metaType = model.Add(typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipLowReserve), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for RevokeSponsorshipLowReserve</summary>
        public static readonly Marshaller<Stellar.RevokeSponsorshipResult.RevokeSponsorshipLowReserve> RevokeSponsorshipLowReserveMarshaller = Marshallers.Create<Stellar.RevokeSponsorshipResult.RevokeSponsorshipLowReserve>(
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
                        return Serializer.Deserialize<Stellar.RevokeSponsorshipResult.RevokeSponsorshipLowReserve>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
