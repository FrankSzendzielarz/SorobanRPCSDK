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
    /// <summary>Custom marshaller for Stellar.SCPStatement+pledgesUnion+prepareStruct</summary>
    public static class SCPStatementpledgesUnionprepareStructGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPStatementpledgesUnionprepareStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPStatement.pledgesUnion.prepareStruct
            if (!model.IsDefined(typeof(Stellar.SCPStatement.pledgesUnion.prepareStruct)))
            {
                var metaType = model.Add(typeof(Stellar.SCPStatement.pledgesUnion.prepareStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "quorumSetHash");
                metaType.Add(2, "ballot");
                metaType.Add(3, "prepared");
                metaType.Add(4, "preparedPrime");
                metaType.Add(5, "nC");
                metaType.Add(6, "nH");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for prepareStruct</summary>
        public static readonly Marshaller<Stellar.SCPStatement.pledgesUnion.prepareStruct> prepareStructMarshaller = Marshallers.Create<Stellar.SCPStatement.pledgesUnion.prepareStruct>(
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
                        return Serializer.Deserialize<Stellar.SCPStatement.pledgesUnion.prepareStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
