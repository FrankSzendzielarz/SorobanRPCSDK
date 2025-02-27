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
    /// <summary>Custom marshaller for Stellar.RevokeSponsorshipResult+RevokeSponsorshipNotSponsor</summary>
    public static class RevokeSponsorshipResultRevokeSponsorshipNotSponsorGrpcMarshaller
    {
        // Static constructor to configure type
        static RevokeSponsorshipResultRevokeSponsorshipNotSponsorGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RevokeSponsorshipResult.RevokeSponsorshipNotSponsor
            if (!model.IsDefined(typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipNotSponsor)))
            {
                var metaType = model.Add(typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipNotSponsor), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RevokeSponsorshipResult+RevokeSponsorshipNotSponsor</summary>
        public static readonly Marshaller<Stellar.RevokeSponsorshipResult.RevokeSponsorshipNotSponsor> RevokeSponsorshipResult_RevokeSponsorshipNotSponsorMarshaller = Marshallers.Create<Stellar.RevokeSponsorshipResult.RevokeSponsorshipNotSponsor>(
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
                        return Serializer.Deserialize<Stellar.RevokeSponsorshipResult.RevokeSponsorshipNotSponsor>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
