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
    /// <summary>Custom marshaller for Stellar.SCSpecUDTUnionCaseV0Kind</summary>
    public static class SCSpecUDTUnionCaseV0KindGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecUDTUnionCaseV0KindGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecUDTUnionCaseV0Kind
            if (!model.IsDefined(typeof(Stellar.SCSpecUDTUnionCaseV0Kind)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecUDTUnionCaseV0Kind), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecUDTUnionCaseV0Kind</summary>
        public static readonly Marshaller<Stellar.SCSpecUDTUnionCaseV0Kind> SCSpecUDTUnionCaseV0KindMarshaller = Marshallers.Create<Stellar.SCSpecUDTUnionCaseV0Kind>(
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
                        return Serializer.Deserialize<Stellar.SCSpecUDTUnionCaseV0Kind>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
