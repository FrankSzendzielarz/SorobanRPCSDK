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
    /// <summary>Custom marshaller for Stellar.SCPStatement+pledgesUnion+confirmStruct</summary>
    public static class SCPStatementpledgesUnionconfirmStructGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPStatementpledgesUnionconfirmStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPStatement.pledgesUnion.confirmStruct
            if (!model.IsDefined(typeof(Stellar.SCPStatement.pledgesUnion.confirmStruct)))
            {
                var metaType = model.Add(typeof(Stellar.SCPStatement.pledgesUnion.confirmStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ballot");
                metaType.Add(2, "nPrepared");
                metaType.Add(3, "nCommit");
                metaType.Add(4, "nH");
                metaType.Add(5, "quorumSetHash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCPStatement+pledgesUnion+confirmStruct</summary>
        public static readonly Marshaller<Stellar.SCPStatement.pledgesUnion.confirmStruct> SCPStatement_pledgesUnion_confirmStructMarshaller = Marshallers.Create<Stellar.SCPStatement.pledgesUnion.confirmStruct>(
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
                        return Serializer.Deserialize<Stellar.SCPStatement.pledgesUnion.confirmStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
