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
    /// <summary>Custom marshaller for Stellar.SCSpecUDTErrorEnumCaseV0</summary>
    public static class SCSpecUDTErrorEnumCaseV0GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecUDTErrorEnumCaseV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecUDTErrorEnumCaseV0
            if (!model.IsDefined(typeof(Stellar.SCSpecUDTErrorEnumCaseV0)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecUDTErrorEnumCaseV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "doc");
                metaType.Add(2, "name");
                metaType.Add(3, "value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecUDTErrorEnumCaseV0</summary>
        public static readonly Marshaller<Stellar.SCSpecUDTErrorEnumCaseV0> SCSpecUDTErrorEnumCaseV0Marshaller = Marshallers.Create<Stellar.SCSpecUDTErrorEnumCaseV0>(
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
                        return Serializer.Deserialize<Stellar.SCSpecUDTErrorEnumCaseV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
