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
    /// <summary>Custom marshaller for Stellar.SetOptionsResult+SetOptionsTooManySigners</summary>
    public static class SetOptionsResultSetOptionsTooManySignersGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsResultSetOptionsTooManySignersGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsResult.SetOptionsTooManySigners
            if (!model.IsDefined(typeof(Stellar.SetOptionsResult.SetOptionsTooManySigners)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsResult.SetOptionsTooManySigners), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SetOptionsResult+SetOptionsTooManySigners</summary>
        public static readonly Marshaller<Stellar.SetOptionsResult.SetOptionsTooManySigners> SetOptionsResult_SetOptionsTooManySignersMarshaller = Marshallers.Create<Stellar.SetOptionsResult.SetOptionsTooManySigners>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsResult.SetOptionsTooManySigners>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
