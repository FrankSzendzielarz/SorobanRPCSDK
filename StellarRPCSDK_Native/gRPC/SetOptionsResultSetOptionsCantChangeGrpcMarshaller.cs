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
    /// <summary>Custom marshaller for Stellar.SetOptionsResult+SetOptionsCantChange</summary>
    public static class SetOptionsResultSetOptionsCantChangeGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsResultSetOptionsCantChangeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsResult.SetOptionsCantChange
            if (!model.IsDefined(typeof(Stellar.SetOptionsResult.SetOptionsCantChange)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsResult.SetOptionsCantChange), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SetOptionsResult+SetOptionsCantChange</summary>
        public static readonly Marshaller<Stellar.SetOptionsResult.SetOptionsCantChange> SetOptionsResult_SetOptionsCantChangeMarshaller = Marshallers.Create<Stellar.SetOptionsResult.SetOptionsCantChange>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsResult.SetOptionsCantChange>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
