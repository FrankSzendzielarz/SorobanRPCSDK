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
    /// <summary>Custom marshaller for Stellar.SetTrustLineFlagsResult+SetTrustLineFlagsInvalidState</summary>
    public static class SetTrustLineFlagsResultSetTrustLineFlagsInvalidStateGrpcMarshaller
    {
        // Static constructor to configure type
        static SetTrustLineFlagsResultSetTrustLineFlagsInvalidStateGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState
            if (!model.IsDefined(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState)))
            {
                var metaType = model.Add(typeof(Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetTrustLineFlagsInvalidState</summary>
        public static readonly Marshaller<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState> SetTrustLineFlagsInvalidStateMarshaller = Marshallers.Create<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState>(
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
                        return Serializer.Deserialize<Stellar.SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
