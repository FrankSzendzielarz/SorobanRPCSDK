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
    /// <summary>Custom marshaller for Stellar.SCPStatement+pledgesUnion+ScpStPrepare</summary>
    public static class SCPStatementpledgesUnionScpStPrepareGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPStatementpledgesUnionScpStPrepareGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPStatement.pledgesUnion.ScpStPrepare
            if (!model.IsDefined(typeof(Stellar.SCPStatement.pledgesUnion.ScpStPrepare)))
            {
                var metaType = model.Add(typeof(Stellar.SCPStatement.pledgesUnion.ScpStPrepare), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "prepare");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScpStPrepare</summary>
        public static readonly Marshaller<Stellar.SCPStatement.pledgesUnion.ScpStPrepare> ScpStPrepareMarshaller = Marshallers.Create<Stellar.SCPStatement.pledgesUnion.ScpStPrepare>(
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
                        return Serializer.Deserialize<Stellar.SCPStatement.pledgesUnion.ScpStPrepare>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
