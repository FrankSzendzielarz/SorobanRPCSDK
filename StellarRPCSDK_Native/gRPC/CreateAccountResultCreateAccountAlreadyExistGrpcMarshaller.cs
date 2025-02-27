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
    /// <summary>Custom marshaller for Stellar.CreateAccountResult+CreateAccountAlreadyExist</summary>
    public static class CreateAccountResultCreateAccountAlreadyExistGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateAccountResultCreateAccountAlreadyExistGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateAccountResult.CreateAccountAlreadyExist
            if (!model.IsDefined(typeof(Stellar.CreateAccountResult.CreateAccountAlreadyExist)))
            {
                var metaType = model.Add(typeof(Stellar.CreateAccountResult.CreateAccountAlreadyExist), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.CreateAccountResult+CreateAccountAlreadyExist</summary>
        public static readonly Marshaller<Stellar.CreateAccountResult.CreateAccountAlreadyExist> CreateAccountResult_CreateAccountAlreadyExistMarshaller = Marshallers.Create<Stellar.CreateAccountResult.CreateAccountAlreadyExist>(
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
                        return Serializer.Deserialize<Stellar.CreateAccountResult.CreateAccountAlreadyExist>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
