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
    /// <summary>Custom marshaller for Stellar.PersistedSCPState</summary>
    public static class PersistedSCPStateGrpcMarshaller
    {
        // Static constructor to configure type
        static PersistedSCPStateGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PersistedSCPState
            if (!model.IsDefined(typeof(Stellar.PersistedSCPState)))
            {
                var metaType = model.Add(typeof(Stellar.PersistedSCPState), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.PersistedSCPState.case_0));
                metaType.AddSubType(101, typeof(Stellar.PersistedSCPState.case_1));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PersistedSCPState</summary>
        public static readonly Marshaller<Stellar.PersistedSCPState> PersistedSCPStateMarshaller = Marshallers.Create<Stellar.PersistedSCPState>(
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
                        return Serializer.Deserialize<Stellar.PersistedSCPState>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
