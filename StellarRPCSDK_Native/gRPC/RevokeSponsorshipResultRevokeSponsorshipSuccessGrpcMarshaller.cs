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
    /// <summary>Custom marshaller for Stellar.RevokeSponsorshipResult+RevokeSponsorshipSuccess</summary>
    public static class RevokeSponsorshipResultRevokeSponsorshipSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static RevokeSponsorshipResultRevokeSponsorshipSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RevokeSponsorshipResult.RevokeSponsorshipSuccess
            if (!model.IsDefined(typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RevokeSponsorshipResult+RevokeSponsorshipSuccess</summary>
        public static readonly Marshaller<Stellar.RevokeSponsorshipResult.RevokeSponsorshipSuccess> RevokeSponsorshipResult_RevokeSponsorshipSuccessMarshaller = Marshallers.Create<Stellar.RevokeSponsorshipResult.RevokeSponsorshipSuccess>(
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
                        return Serializer.Deserialize<Stellar.RevokeSponsorshipResult.RevokeSponsorshipSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
