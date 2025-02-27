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
    /// <summary>Custom marshaller for Stellar.SCPStatement+pledgesUnion+ScpStExternalize</summary>
    public static class SCPStatementpledgesUnionScpStExternalizeGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPStatementpledgesUnionScpStExternalizeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPStatement.pledgesUnion.ScpStExternalize
            if (!model.IsDefined(typeof(Stellar.SCPStatement.pledgesUnion.ScpStExternalize)))
            {
                var metaType = model.Add(typeof(Stellar.SCPStatement.pledgesUnion.ScpStExternalize), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "externalize");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCPStatement+pledgesUnion+ScpStExternalize</summary>
        public static readonly Marshaller<Stellar.SCPStatement.pledgesUnion.ScpStExternalize> SCPStatement_pledgesUnion_ScpStExternalizeMarshaller = Marshallers.Create<Stellar.SCPStatement.pledgesUnion.ScpStExternalize>(
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
                        return Serializer.Deserialize<Stellar.SCPStatement.pledgesUnion.ScpStExternalize>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
