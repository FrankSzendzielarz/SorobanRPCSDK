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
    /// <summary>Custom marshaller for Stellar.RPC.SimulateTransactionResult_ProtoWrapper+ApplyToParam</summary>
    public static class SimulateTransactionResult_ProtoWrapperApplyToParamGrpcMarshaller
    {
        // Static constructor to configure type
        static SimulateTransactionResult_ProtoWrapperApplyToParamGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam
            if (!model.IsDefined(typeof(Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Simulation");
                metaType.Add(2, "Original");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.SimulateTransactionResult_ProtoWrapper+ApplyToParam</summary>
        public static readonly Marshaller<Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam> SimulateTransactionResult_ProtoWrapper_ApplyToParamMarshaller = Marshallers.Create<Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam>(
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
                        return Serializer.Deserialize<Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
