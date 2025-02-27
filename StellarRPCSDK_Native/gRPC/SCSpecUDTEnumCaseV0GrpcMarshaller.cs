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
    /// <summary>Custom marshaller for Stellar.SCSpecUDTEnumCaseV0</summary>
    public static class SCSpecUDTEnumCaseV0GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecUDTEnumCaseV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecUDTEnumCaseV0
            if (!model.IsDefined(typeof(Stellar.SCSpecUDTEnumCaseV0)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecUDTEnumCaseV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "doc");
                metaType.Add(2, "name");
                metaType.Add(3, "value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecUDTEnumCaseV0</summary>
        public static readonly Marshaller<Stellar.SCSpecUDTEnumCaseV0> SCSpecUDTEnumCaseV0Marshaller = Marshallers.Create<Stellar.SCSpecUDTEnumCaseV0>(
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
                        return Serializer.Deserialize<Stellar.SCSpecUDTEnumCaseV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
