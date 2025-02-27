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
    /// <summary>Custom marshaller for Stellar.SCPStatement+pledgesUnion+externalizeStruct</summary>
    public static class SCPStatementpledgesUnionexternalizeStructGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPStatementpledgesUnionexternalizeStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPStatement.pledgesUnion.externalizeStruct
            if (!model.IsDefined(typeof(Stellar.SCPStatement.pledgesUnion.externalizeStruct)))
            {
                var metaType = model.Add(typeof(Stellar.SCPStatement.pledgesUnion.externalizeStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "commit");
                metaType.Add(2, "nH");
                metaType.Add(3, "commitQuorumSetHash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCPStatement+pledgesUnion+externalizeStruct</summary>
        public static readonly Marshaller<Stellar.SCPStatement.pledgesUnion.externalizeStruct> SCPStatement_pledgesUnion_externalizeStructMarshaller = Marshallers.Create<Stellar.SCPStatement.pledgesUnion.externalizeStruct>(
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
                        return Serializer.Deserialize<Stellar.SCPStatement.pledgesUnion.externalizeStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
