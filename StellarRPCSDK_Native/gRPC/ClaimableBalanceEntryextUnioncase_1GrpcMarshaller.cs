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
    /// <summary>Custom marshaller for Stellar.ClaimableBalanceEntry+extUnion+case_1</summary>
    public static class ClaimableBalanceEntryextUnioncase_1GrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimableBalanceEntryextUnioncase_1GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimableBalanceEntry.extUnion.case_1
            if (!model.IsDefined(typeof(Stellar.ClaimableBalanceEntry.extUnion.case_1)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimableBalanceEntry.extUnion.case_1), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "v1");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClaimableBalanceEntry+extUnion+case_1</summary>
        public static readonly Marshaller<Stellar.ClaimableBalanceEntry.extUnion.case_1> ClaimableBalanceEntry_extUnion_case_1Marshaller = Marshallers.Create<Stellar.ClaimableBalanceEntry.extUnion.case_1>(
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
                        return Serializer.Deserialize<Stellar.ClaimableBalanceEntry.extUnion.case_1>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
