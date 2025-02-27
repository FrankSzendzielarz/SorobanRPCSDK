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
    /// <summary>Custom marshaller for Stellar.CreateAccountResult+CreateAccountUnderfunded</summary>
    public static class CreateAccountResultCreateAccountUnderfundedGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateAccountResultCreateAccountUnderfundedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateAccountResult.CreateAccountUnderfunded
            if (!model.IsDefined(typeof(Stellar.CreateAccountResult.CreateAccountUnderfunded)))
            {
                var metaType = model.Add(typeof(Stellar.CreateAccountResult.CreateAccountUnderfunded), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for CreateAccountUnderfunded</summary>
        public static readonly Marshaller<Stellar.CreateAccountResult.CreateAccountUnderfunded> CreateAccountUnderfundedMarshaller = Marshallers.Create<Stellar.CreateAccountResult.CreateAccountUnderfunded>(
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
                        return Serializer.Deserialize<Stellar.CreateAccountResult.CreateAccountUnderfunded>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
