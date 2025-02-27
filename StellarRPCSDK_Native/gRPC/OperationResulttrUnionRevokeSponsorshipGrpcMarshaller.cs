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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+RevokeSponsorship</summary>
    public static class OperationResulttrUnionRevokeSponsorshipGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionRevokeSponsorshipGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.RevokeSponsorship
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.RevokeSponsorship)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.RevokeSponsorship), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(19, "revokeSponsorshipResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for RevokeSponsorship</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.RevokeSponsorship> RevokeSponsorshipMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.RevokeSponsorship>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.RevokeSponsorship>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
