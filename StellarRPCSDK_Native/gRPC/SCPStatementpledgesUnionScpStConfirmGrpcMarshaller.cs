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
    /// <summary>Custom marshaller for Stellar.SCPStatement+pledgesUnion+ScpStConfirm</summary>
    public static class SCPStatementpledgesUnionScpStConfirmGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPStatementpledgesUnionScpStConfirmGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPStatement.pledgesUnion.ScpStConfirm
            if (!model.IsDefined(typeof(Stellar.SCPStatement.pledgesUnion.ScpStConfirm)))
            {
                var metaType = model.Add(typeof(Stellar.SCPStatement.pledgesUnion.ScpStConfirm), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "confirm");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCPStatement+pledgesUnion+ScpStConfirm</summary>
        public static readonly Marshaller<Stellar.SCPStatement.pledgesUnion.ScpStConfirm> SCPStatement_pledgesUnion_ScpStConfirmMarshaller = Marshallers.Create<Stellar.SCPStatement.pledgesUnion.ScpStConfirm>(
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
                        return Serializer.Deserialize<Stellar.SCPStatement.pledgesUnion.ScpStConfirm>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
