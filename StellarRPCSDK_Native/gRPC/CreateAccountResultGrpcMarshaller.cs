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
    /// <summary>Custom marshaller for Stellar.CreateAccountResult</summary>
    public static class CreateAccountResultGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateAccountResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateAccountResult
            if (!model.IsDefined(typeof(Stellar.CreateAccountResult)))
            {
                var metaType = model.Add(typeof(Stellar.CreateAccountResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.CreateAccountResult.CreateAccountSuccess));
                metaType.AddSubType(101, typeof(Stellar.CreateAccountResult.CreateAccountMalformed));
                metaType.AddSubType(102, typeof(Stellar.CreateAccountResult.CreateAccountUnderfunded));
                metaType.AddSubType(103, typeof(Stellar.CreateAccountResult.CreateAccountLowReserve));
                metaType.AddSubType(104, typeof(Stellar.CreateAccountResult.CreateAccountAlreadyExist));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for CreateAccountResult</summary>
        public static readonly Marshaller<Stellar.CreateAccountResult> CreateAccountResultMarshaller = Marshallers.Create<Stellar.CreateAccountResult>(
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
                        return Serializer.Deserialize<Stellar.CreateAccountResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
