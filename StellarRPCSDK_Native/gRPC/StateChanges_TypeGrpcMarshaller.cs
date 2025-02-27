// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.StateChanges_Type</summary>
    public static class StateChanges_TypeGrpcMarshaller
    {
        // Static constructor to configure type
        static StateChanges_TypeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.StateChanges_Type
            if (!model.IsDefined(typeof(Stellar.RPC.StateChanges_Type)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.StateChanges_Type), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.StateChanges_Type</summary>
        public static readonly Marshaller<Stellar.RPC.StateChanges_Type> StateChanges_TypeMarshaller = Marshallers.Create<Stellar.RPC.StateChanges_Type>(
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
                        return Serializer.Deserialize<Stellar.RPC.StateChanges_Type>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
