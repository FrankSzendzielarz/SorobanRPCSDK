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
    /// <summary>Custom marshaller for Stellar.RevokeSponsorshipResult</summary>
    public static class RevokeSponsorshipResultGrpcMarshaller
    {
        // Static constructor to configure type
        static RevokeSponsorshipResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RevokeSponsorshipResult
            if (!model.IsDefined(typeof(Stellar.RevokeSponsorshipResult)))
            {
                var metaType = model.Add(typeof(Stellar.RevokeSponsorshipResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipSuccess));
                metaType.AddSubType(101, typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipDoesNotExist));
                metaType.AddSubType(102, typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipNotSponsor));
                metaType.AddSubType(103, typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipLowReserve));
                metaType.AddSubType(104, typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipOnlyTransferable));
                metaType.AddSubType(105, typeof(Stellar.RevokeSponsorshipResult.RevokeSponsorshipMalformed));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for RevokeSponsorshipResult</summary>
        public static readonly Marshaller<Stellar.RevokeSponsorshipResult> RevokeSponsorshipResultMarshaller = Marshallers.Create<Stellar.RevokeSponsorshipResult>(
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
                        return Serializer.Deserialize<Stellar.RevokeSponsorshipResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
