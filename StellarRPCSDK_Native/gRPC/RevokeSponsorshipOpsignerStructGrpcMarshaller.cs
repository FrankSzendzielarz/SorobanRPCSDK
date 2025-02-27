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
    /// <summary>Custom marshaller for Stellar.RevokeSponsorshipOp+signerStruct</summary>
    public static class RevokeSponsorshipOpsignerStructGrpcMarshaller
    {
        // Static constructor to configure type
        static RevokeSponsorshipOpsignerStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RevokeSponsorshipOp.signerStruct
            if (!model.IsDefined(typeof(Stellar.RevokeSponsorshipOp.signerStruct)))
            {
                var metaType = model.Add(typeof(Stellar.RevokeSponsorshipOp.signerStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "accountID");
                metaType.Add(2, "signerKey");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for signerStruct</summary>
        public static readonly Marshaller<Stellar.RevokeSponsorshipOp.signerStruct> signerStructMarshaller = Marshallers.Create<Stellar.RevokeSponsorshipOp.signerStruct>(
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
                        return Serializer.Deserialize<Stellar.RevokeSponsorshipOp.signerStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
