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
    /// <summary>Custom marshaller for Stellar.SCPStatement+pledgesUnion</summary>
    public static class SCPStatementpledgesUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPStatementpledgesUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPStatement.pledgesUnion
            if (!model.IsDefined(typeof(Stellar.SCPStatement.pledgesUnion)))
            {
                var metaType = model.Add(typeof(Stellar.SCPStatement.pledgesUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SCPStatement.pledgesUnion.ScpStPrepare));
                metaType.AddSubType(101, typeof(Stellar.SCPStatement.pledgesUnion.ScpStConfirm));
                metaType.AddSubType(102, typeof(Stellar.SCPStatement.pledgesUnion.ScpStExternalize));
                metaType.AddSubType(103, typeof(Stellar.SCPStatement.pledgesUnion.ScpStNominate));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for pledgesUnion</summary>
        public static readonly Marshaller<Stellar.SCPStatement.pledgesUnion> pledgesUnionMarshaller = Marshallers.Create<Stellar.SCPStatement.pledgesUnion>(
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
                        return Serializer.Deserialize<Stellar.SCPStatement.pledgesUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
