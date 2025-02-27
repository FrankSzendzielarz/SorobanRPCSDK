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
    /// <summary>Custom marshaller for Stellar.SCPStatement+pledgesUnion+ScpStNominate</summary>
    public static class SCPStatementpledgesUnionScpStNominateGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPStatementpledgesUnionScpStNominateGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPStatement.pledgesUnion.ScpStNominate
            if (!model.IsDefined(typeof(Stellar.SCPStatement.pledgesUnion.ScpStNominate)))
            {
                var metaType = model.Add(typeof(Stellar.SCPStatement.pledgesUnion.ScpStNominate), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "nominate");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScpStNominate</summary>
        public static readonly Marshaller<Stellar.SCPStatement.pledgesUnion.ScpStNominate> ScpStNominateMarshaller = Marshallers.Create<Stellar.SCPStatement.pledgesUnion.ScpStNominate>(
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
                        return Serializer.Deserialize<Stellar.SCPStatement.pledgesUnion.ScpStNominate>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
