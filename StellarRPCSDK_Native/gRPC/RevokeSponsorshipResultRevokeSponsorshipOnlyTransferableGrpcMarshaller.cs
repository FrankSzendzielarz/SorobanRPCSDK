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
    /// <summary>Custom marshaller for Stellar.RevokeSponsorshipResult+RevokeSponsorshipOnlyTransferable</summary>
    public static class RevokeSponsorshipResultRevokeSponsorshipOnlyTransferableGrpcMarshaller
    {
        // Static constructor to configure type
        static RevokeSponsorshipResultRevokeSponsorshipOnlyTransferableGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable
            if (!model.IsDefined(typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable)))
            {
                var metaType = model.Add(typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RevokeSponsorshipResult+RevokeSponsorshipOnlyTransferable</summary>
        public static readonly Marshaller<Stellar.RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable> RevokeSponsorshipResult_RevokeSponsorshipOnlyTransferableMarshaller = Marshallers.Create<Stellar.RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable>(
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
                        return Serializer.Deserialize<Stellar.RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
