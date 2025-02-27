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
    /// <summary>Custom marshaller for Stellar.CreateAccountResult+CreateAccountSuccess</summary>
    public static class CreateAccountResultCreateAccountSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateAccountResultCreateAccountSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateAccountResult.CreateAccountSuccess
            if (!model.IsDefined(typeof(Stellar.CreateAccountResult.CreateAccountSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.CreateAccountResult.CreateAccountSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for CreateAccountSuccess</summary>
        public static readonly Marshaller<Stellar.CreateAccountResult.CreateAccountSuccess> CreateAccountSuccessMarshaller = Marshallers.Create<Stellar.CreateAccountResult.CreateAccountSuccess>(
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
                        return Serializer.Deserialize<Stellar.CreateAccountResult.CreateAccountSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
