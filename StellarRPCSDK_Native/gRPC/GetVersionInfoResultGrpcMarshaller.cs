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
    /// <summary>Custom marshaller for Stellar.RPC.GetVersionInfoResult</summary>
    public static class GetVersionInfoResultGrpcMarshaller
    {
        // Static constructor to configure type
        static GetVersionInfoResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetVersionInfoResult
            if (!model.IsDefined(typeof(Stellar.RPC.GetVersionInfoResult)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetVersionInfoResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Version");
                metaType.Add(2, "Commit_hash");
                metaType.Add(3, "Build_time_stamp");
                metaType.Add(4, "Captive_core_version");
                metaType.Add(5, "Protocol_version");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.GetVersionInfoResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetVersionInfoResult> GetVersionInfoResultMarshaller = Marshallers.Create<Stellar.RPC.GetVersionInfoResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetVersionInfoResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
