// Generated code - do not modify directly
using System;
using Grpc.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Stellar;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Extension methods for registering AOT-compatible gRPC services</summary>
    public static class GrpcServiceExtensions
    {
        /// <summary>Add all AOT-compatible gRPC services to the DI container</summary>
        public static IServiceCollection AddAotGrpcServices(this IServiceCollection services)
        {
            // Add base gRPC infrastructure
            services.AddGrpc(options =>
            {
                options.EnableDetailedErrors = true;
                options.MaxReceiveMessageSize = 16 * 1024 * 1024; // 16 MB
                options.MaxSendMessageSize = 16 * 1024 * 1024; // 16 MB
            });

            // Register IXdrProtoService and its gRPC adapter
            services.AddScoped<IXdrProtoService, XdrProtoService>();
            services.AddScoped<XdrProtoServiceGrpcService>();
            // Register IMuxedAccount_ProtoWrapper and its gRPC adapter
            services.AddScoped<IMuxedAccount_ProtoWrapper, MuxedAccount_ProtoWrapper>();
            services.AddScoped<MuxedAccount_ProtoWrapperGrpcService>();
            // Register INetwork_ProtoWrapper and its gRPC adapter
            services.AddScoped<INetwork_ProtoWrapper, Network_ProtoWrapper>();
            services.AddScoped<Network_ProtoWrapperGrpcService>();
            // Register ITransaction_ProtoWrapper and its gRPC adapter
            services.AddScoped<ITransaction_ProtoWrapper, Transaction_ProtoWrapper>();
            services.AddScoped<Transaction_ProtoWrapperGrpcService>();
            // Register ISimulateTransactionResult_ProtoWrapper and its gRPC adapter
            services.AddScoped<ISimulateTransactionResult_ProtoWrapper, SimulateTransactionResult_ProtoWrapper>();
            services.AddScoped<SimulateTransactionResult_ProtoWrapperGrpcService>();
            // Register IStellarRPCClient and its gRPC adapter
            services.AddScoped<IStellarRPCClient, StellarRPCClient>();
            services.AddScoped<StellarRPCClientGrpcService>();

            return services;
        }

        /// <summary>Map all AOT-compatible gRPC services to endpoints</summary>
        public static IEndpointRouteBuilder MapAotGrpcServices(this IEndpointRouteBuilder endpoints)
        {
            // Ensure all marshallers are configured
            XdrProtoServiceGrpcMarshaller.ConfigureTypes();
            MuxedAccount_ProtoWrapperGrpcMarshaller.ConfigureTypes();
            Network_ProtoWrapperGrpcMarshaller.ConfigureTypes();
            Transaction_ProtoWrapperGrpcMarshaller.ConfigureTypes();
            SimulateTransactionResult_ProtoWrapperGrpcMarshaller.ConfigureTypes();
            StellarRPCClientGrpcMarshaller.ConfigureTypes();

            // Map IXdrProtoService methods
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigSettingContractExecutionLanesV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigSettingContractExecutionLanesV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigSettingContractComputeV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigSettingContractComputeV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigSettingContractLedgerCostV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigSettingContractLedgerCostV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigSettingContractHistoricalDataV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigSettingContractHistoricalDataV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigSettingContractEventsV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigSettingContractEventsV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigSettingContractBandwidthV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigSettingContractBandwidthV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractCostTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractCostTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractCostParamEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractCostParamEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeStateArchivalSettingsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeStateArchivalSettingsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeEvictionIteratorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeEvictionIteratorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractCostParamsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractCostParamsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigSettingIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigSettingIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigSettingEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigSettingEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCEnvMetaKindMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCEnvMetaKindMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCEnvMetaEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCEnvMetaEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCMetaV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCMetaV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCMetaKindMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCMetaKindMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCMetaEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCMetaEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeOptionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeOptionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeVecMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeVecMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeMapMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeMapMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeTupleMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeTupleMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeBytesNMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeBytesNMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeUDTMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeUDTMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecTypeDefMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecTypeDefMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTStructFieldV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTStructFieldV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTStructV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTStructV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTUnionCaseVoidV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTUnionCaseVoidV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTUnionCaseTupleV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTUnionCaseTupleV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTUnionCaseV0KindMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTUnionCaseV0KindMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTUnionCaseV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTUnionCaseV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTUnionV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTUnionV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTEnumCaseV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTEnumCaseV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTEnumV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTEnumV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTErrorEnumCaseV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTErrorEnumCaseV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecUDTErrorEnumV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecUDTErrorEnumV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecFunctionInputV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecFunctionInputV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecFunctionV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecFunctionV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecEntryKindMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecEntryKindMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSpecEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSpecEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCValTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCValTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCErrorTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCErrorTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCErrorCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCErrorCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCErrorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCErrorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeUInt128PartsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeUInt128PartsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInt128PartsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInt128PartsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeUInt256PartsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeUInt256PartsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInt256PartsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInt256PartsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractExecutableTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractExecutableTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractExecutableMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractExecutableMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCAddressTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCAddressTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCAddressMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCAddressMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCVecMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCVecMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCMapMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCMapMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCBytesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCBytesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCStringMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCStringMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCSymbolMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCSymbolMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCNonceKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCNonceKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCContractInstanceMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCContractInstanceMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCValMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCValMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCMapEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCMapEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeStoredTransactionSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeStoredTransactionSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeStoredDebugTransactionSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeStoredDebugTransactionSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePersistedSCPStateV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePersistedSCPStateV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePersistedSCPStateV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePersistedSCPStateV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePersistedSCPStateMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePersistedSCPStateMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeThresholdsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeThresholdsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Encodestring32Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Decodestring32Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Encodestring64Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Decodestring64Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSequenceNumberMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSequenceNumberMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeDataValueMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeDataValueMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePoolIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePoolIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAssetCode4Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAssetCode4Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAssetCode12Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAssetCode12Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAssetTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAssetTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAssetCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAssetCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAlphaNum4Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAlphaNum4Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAlphaNum12Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAlphaNum12Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAssetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAssetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePriceMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePriceMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiabilitiesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiabilitiesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeThresholdIndexesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeThresholdIndexesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerEntryTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerEntryTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignerMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignerMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAccountFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAccountFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSponsorshipDescriptorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSponsorshipDescriptorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAccountEntryExtensionV3Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAccountEntryExtensionV3Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAccountEntryExtensionV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAccountEntryExtensionV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAccountEntryExtensionV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAccountEntryExtensionV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAccountEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAccountEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTrustLineFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTrustLineFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTrustLineAssetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTrustLineAssetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTrustLineEntryExtensionV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTrustLineEntryExtensionV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTrustLineEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTrustLineEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeOfferEntryFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeOfferEntryFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeOfferEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeOfferEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeDataEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeDataEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimPredicateTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimPredicateTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimPredicateMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimPredicateMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimantTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimantTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimantMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimantMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimableBalanceIDTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimableBalanceIDTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimableBalanceIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimableBalanceIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimableBalanceFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimableBalanceFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimableBalanceEntryExtensionV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimableBalanceEntryExtensionV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimableBalanceEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimableBalanceEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolConstantProductParametersMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolConstantProductParametersMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractDataDurabilityMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractDataDurabilityMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractDataEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractDataEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractCodeCostInputsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractCodeCostInputsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractCodeEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractCodeEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTTLEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTTLEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerEntryExtensionV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerEntryExtensionV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeEnvelopeTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeEnvelopeTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBucketListTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBucketListTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBucketEntryTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBucketEntryTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHotArchiveBucketEntryTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHotArchiveBucketEntryTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeColdArchiveBucketEntryTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeColdArchiveBucketEntryTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBucketMetadataMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBucketMetadataMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBucketEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBucketEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHotArchiveBucketEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHotArchiveBucketEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeColdArchiveArchivedLeafMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeColdArchiveArchivedLeafMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeColdArchiveDeletedLeafMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeColdArchiveDeletedLeafMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeColdArchiveBoundaryLeafMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeColdArchiveBoundaryLeafMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeColdArchiveHashEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeColdArchiveHashEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeColdArchiveBucketEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeColdArchiveBucketEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeUpgradeTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeUpgradeTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeStellarValueTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeStellarValueTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerCloseValueSignatureMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerCloseValueSignatureMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeStellarValueMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeStellarValueMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerHeaderFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerHeaderFlagsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerHeaderExtensionV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerHeaderExtensionV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerHeaderMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerHeaderMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerUpgradeTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerUpgradeTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigUpgradeSetKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigUpgradeSetKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerUpgradeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerUpgradeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeConfigUpgradeSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeConfigUpgradeSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTxSetComponentTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTxSetComponentTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTxSetComponentMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTxSetComponentMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionPhaseMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionPhaseMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionSetV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionSetV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeGeneralizedTransactionSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeGeneralizedTransactionSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionResultPairMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionResultPairMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionResultSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionResultSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionHistoryEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionHistoryEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionHistoryResultEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionHistoryResultEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerHeaderHistoryEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerHeaderHistoryEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerSCPMessagesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerSCPMessagesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCPHistoryEntryV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCPHistoryEntryV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCPHistoryEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCPHistoryEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerEntryChangeTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerEntryChangeTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerEntryChangeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerEntryChangeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerEntryChangesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerEntryChangesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeOperationMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeOperationMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionMetaV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionMetaV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionMetaV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionMetaV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractEventTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractEventTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractEventMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractEventMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeDiagnosticEventMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeDiagnosticEventMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeDiagnosticEventsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeDiagnosticEventsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanTransactionMetaExtV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanTransactionMetaExtV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanTransactionMetaExtMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanTransactionMetaExtMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanTransactionMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanTransactionMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionMetaV3Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionMetaV3Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInvokeHostFunctionSuccessPreImageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInvokeHostFunctionSuccessPreImageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionResultMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionResultMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeUpgradeEntryMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeUpgradeEntryMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerCloseMetaV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerCloseMetaV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerCloseMetaExtV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerCloseMetaExtV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerCloseMetaExtMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerCloseMetaExtMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerCloseMetaV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerCloseMetaV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerCloseMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerCloseMetaMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeErrorCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeErrorCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeErrorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeErrorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSendMoreMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSendMoreMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSendMoreExtendedMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSendMoreExtendedMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAuthCertMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAuthCertMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHelloMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHelloMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAuthMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAuthMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeIPAddrTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeIPAddrTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePeerAddressMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePeerAddressMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeMessageTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeMessageTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeDontHaveMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeDontHaveMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSurveyMessageCommandTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSurveyMessageCommandTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSurveyMessageResponseTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSurveyMessageResponseTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimeSlicedSurveyStartCollectingMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimeSlicedSurveyStartCollectingMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignedTimeSlicedSurveyStartCollectingMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignedTimeSlicedSurveyStartCollectingMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimeSlicedSurveyStopCollectingMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimeSlicedSurveyStopCollectingMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignedTimeSlicedSurveyStopCollectingMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignedTimeSlicedSurveyStopCollectingMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSurveyRequestMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSurveyRequestMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimeSlicedSurveyRequestMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimeSlicedSurveyRequestMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignedSurveyRequestMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignedSurveyRequestMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignedTimeSlicedSurveyRequestMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignedTimeSlicedSurveyRequestMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeEncryptedBodyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeEncryptedBodyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSurveyResponseMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSurveyResponseMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimeSlicedSurveyResponseMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimeSlicedSurveyResponseMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignedSurveyResponseMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignedSurveyResponseMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignedTimeSlicedSurveyResponseMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignedTimeSlicedSurveyResponseMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePeerStatsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePeerStatsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePeerStatListMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePeerStatListMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimeSlicedNodeDataMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimeSlicedNodeDataMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimeSlicedPeerDataMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimeSlicedPeerDataMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimeSlicedPeerDataListMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimeSlicedPeerDataListMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTopologyResponseBodyV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTopologyResponseBodyV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTopologyResponseBodyV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTopologyResponseBodyV1Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTopologyResponseBodyV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTopologyResponseBodyV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSurveyResponseBodyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSurveyResponseBodyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTxAdvertVectorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTxAdvertVectorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeFloodAdvertMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeFloodAdvertMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTxDemandVectorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTxDemandVectorMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeFloodDemandMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeFloodDemandMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeStellarMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeStellarMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAuthenticatedMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAuthenticatedMessageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeValueMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeValueMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCPBallotMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCPBallotMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCPStatementTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCPStatementTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCPNominationMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCPNominationMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCPStatementMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCPStatementMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCPEnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCPEnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSCPQuorumSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSCPQuorumSetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolParametersMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolParametersMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeMuxedAccountMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeMuxedAccountMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeDecoratedSignatureMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeDecoratedSignatureMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeOperationTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeOperationTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreateAccountOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreateAccountOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePaymentOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePaymentOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePathPaymentStrictReceiveOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePathPaymentStrictReceiveOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePathPaymentStrictSendOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePathPaymentStrictSendOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageSellOfferOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageSellOfferOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageBuyOfferOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageBuyOfferOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreatePassiveSellOfferOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreatePassiveSellOfferOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSetOptionsOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSetOptionsOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeChangeTrustAssetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeChangeTrustAssetMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeChangeTrustOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeChangeTrustOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAllowTrustOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAllowTrustOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageDataOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageDataOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBumpSequenceOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBumpSequenceOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreateClaimableBalanceOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreateClaimableBalanceOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimClaimableBalanceOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimClaimableBalanceOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBeginSponsoringFutureReservesOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBeginSponsoringFutureReservesOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeRevokeSponsorshipTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeRevokeSponsorshipTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeRevokeSponsorshipOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeRevokeSponsorshipOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClawbackOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClawbackOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClawbackClaimableBalanceOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClawbackClaimableBalanceOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSetTrustLineFlagsOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSetTrustLineFlagsOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolDepositOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolDepositOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolWithdrawOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolWithdrawOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHostFunctionTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHostFunctionTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractIDPreimageTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractIDPreimageTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeContractIDPreimageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeContractIDPreimageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreateContractArgsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreateContractArgsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreateContractArgsV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreateContractArgsV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInvokeContractArgsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInvokeContractArgsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHostFunctionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHostFunctionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanAuthorizedFunctionTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanAuthorizedFunctionTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanAuthorizedFunctionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanAuthorizedFunctionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanAuthorizedInvocationMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanAuthorizedInvocationMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanAddressCredentialsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanAddressCredentialsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanCredentialsTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanCredentialsTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanCredentialsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanCredentialsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanAuthorizationEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanAuthorizationEntryMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInvokeHostFunctionOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInvokeHostFunctionOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeExtendFootprintTTLOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeExtendFootprintTTLOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeRestoreFootprintOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeRestoreFootprintOpMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeOperationMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeOperationMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHashIDPreimageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHashIDPreimageMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeMemoTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeMemoTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeMemoMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeMemoMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimeBoundsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimeBoundsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerBoundsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerBoundsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePreconditionsV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePreconditionsV2Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePreconditionTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePreconditionTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePreconditionsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePreconditionsMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLedgerFootprintMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLedgerFootprintMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeArchivalProofTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeArchivalProofTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeArchivalProofNodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeArchivalProofNodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeProofLevelMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeProofLevelMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeNonexistenceProofBodyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeNonexistenceProofBodyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeExistenceProofBodyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeExistenceProofBodyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeArchivalProofMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeArchivalProofMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanResourcesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanResourcesMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSorobanTransactionDataMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSorobanTransactionDataMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionV0EnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionV0EnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionV1EnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionV1EnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeFeeBumpTransactionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeFeeBumpTransactionMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeFeeBumpTransactionEnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeFeeBumpTransactionEnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionEnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionEnvelopeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionSignaturePayloadMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionSignaturePayloadMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimAtomTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimAtomTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimOfferAtomV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimOfferAtomV0Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimOfferAtomMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimOfferAtomMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimLiquidityAtomMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimLiquidityAtomMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimAtomMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimAtomMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreateAccountResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreateAccountResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreateAccountResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreateAccountResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePaymentResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePaymentResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePaymentResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePaymentResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePathPaymentStrictReceiveResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePathPaymentStrictReceiveResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSimplePaymentResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSimplePaymentResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePathPaymentStrictReceiveResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePathPaymentStrictReceiveResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePathPaymentStrictSendResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePathPaymentStrictSendResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePathPaymentStrictSendResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePathPaymentStrictSendResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageSellOfferResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageSellOfferResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageOfferEffectMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageOfferEffectMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageOfferSuccessResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageOfferSuccessResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageSellOfferResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageSellOfferResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageBuyOfferResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageBuyOfferResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageBuyOfferResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageBuyOfferResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSetOptionsResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSetOptionsResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSetOptionsResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSetOptionsResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeChangeTrustResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeChangeTrustResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeChangeTrustResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeChangeTrustResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAllowTrustResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAllowTrustResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAllowTrustResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAllowTrustResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAccountMergeResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAccountMergeResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAccountMergeResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAccountMergeResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInflationResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInflationResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInflationPayoutMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInflationPayoutMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInflationResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInflationResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageDataResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageDataResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeManageDataResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeManageDataResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBumpSequenceResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBumpSequenceResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBumpSequenceResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBumpSequenceResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreateClaimableBalanceResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreateClaimableBalanceResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCreateClaimableBalanceResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCreateClaimableBalanceResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimClaimableBalanceResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimClaimableBalanceResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClaimClaimableBalanceResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClaimClaimableBalanceResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBeginSponsoringFutureReservesResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBeginSponsoringFutureReservesResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBeginSponsoringFutureReservesResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBeginSponsoringFutureReservesResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeEndSponsoringFutureReservesResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeEndSponsoringFutureReservesResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeEndSponsoringFutureReservesResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeEndSponsoringFutureReservesResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeRevokeSponsorshipResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeRevokeSponsorshipResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeRevokeSponsorshipResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeRevokeSponsorshipResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClawbackResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClawbackResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClawbackResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClawbackResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClawbackClaimableBalanceResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClawbackClaimableBalanceResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeClawbackClaimableBalanceResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeClawbackClaimableBalanceResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSetTrustLineFlagsResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSetTrustLineFlagsResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSetTrustLineFlagsResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSetTrustLineFlagsResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolDepositResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolDepositResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolDepositResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolDepositResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolWithdrawResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolWithdrawResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeLiquidityPoolWithdrawResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeLiquidityPoolWithdrawResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInvokeHostFunctionResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInvokeHostFunctionResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInvokeHostFunctionResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInvokeHostFunctionResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeExtendFootprintTTLResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeExtendFootprintTTLResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeExtendFootprintTTLResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeExtendFootprintTTLResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeRestoreFootprintResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeRestoreFootprintResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeRestoreFootprintResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeRestoreFootprintResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeOperationResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeOperationResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeOperationResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeOperationResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionResultCodeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInnerTransactionResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInnerTransactionResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeInnerTransactionResultPairMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeInnerTransactionResultPairMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTransactionResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTransactionResultMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHashMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHashMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Encodeuint256Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Decodeuint256Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Encodeuint32Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Decodeuint32Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Encodeint32Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Decodeint32Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Encodeuint64Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Decodeuint64Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Encodeint64Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.Decodeint64Method);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeTimePointMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeTimePointMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeDurationMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeDurationMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeExtensionPointMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeExtensionPointMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCryptoKeyTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCryptoKeyTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePublicKeyTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePublicKeyTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignerKeyTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignerKeyTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodePublicKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodePublicKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignerKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignerKeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignatureMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignatureMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSignatureHintMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSignatureHintMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeNodeIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeNodeIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeAccountIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeAccountIDMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCurve25519SecretMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCurve25519SecretMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeCurve25519PublicMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeCurve25519PublicMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHmacSha256KeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHmacSha256KeyMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeHmacSha256MacMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeHmacSha256MacMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeShortHashSeedMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeShortHashSeedMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeBinaryFuseFilterTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeBinaryFuseFilterTypeMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.EncodeSerializedBinaryFuseFilterMethod);
            endpoints.MapGrpcMethod<XdrProtoServiceGrpcService>(XdrProtoServiceGrpcDescriptor.DecodeSerializedBinaryFuseFilterMethod);

            // Map IMuxedAccount_ProtoWrapper methods

            // Map INetwork_ProtoWrapper methods

            // Map ITransaction_ProtoWrapper methods

            // Map ISimulateTransactionResult_ProtoWrapper methods

            // Map IStellarRPCClient methods

            return endpoints;
        }

        /// <summary>Map a gRPC method to an endpoint</summary>
        private static IEndpointRouteBuilder MapGrpcMethod<TService>(
            this IEndpointRouteBuilder endpoints,
            Method method)
            where TService : class
        {
            var methodName = method.Name;
            var serviceName = method.ServiceName;

            // Create the route template
            var pattern = $"/grpc/{serviceName}/{methodName}";

            // Map POST endpoint for unary calls
            endpoints.MapPost(pattern, async context =>
            {
                var service = context.RequestServices.GetRequiredService<TService>();
                var serviceType = typeof(TService);

                // Find the matching handler method
                var handler = serviceType.GetMethod(methodName);
                if (handler == null)
                {
                    context.Response.StatusCode = 404;
                    await context.Response.WriteAsync($"Method {methodName} not found on service {serviceName}");
                    return;
                }

                try
                {
                    // Create ServerCallContext
                    var serverCallContext = CreateServerCallContext(context);

                    // Get the marshaller for the request type
                    var requestMarshaller = method.GetType().GetField("RequestMarshaller")?.GetValue(method) as Marshaller;
                    if (requestMarshaller == null)
                    {
                        throw new InvalidOperationException("Could not get request marshaller");
                    }

                    // Deserialize the request
                    var deserializeDelegate = requestMarshaller.GetType().GetProperty("ContextualDeserializer")?.GetValue(requestMarshaller) as Func<DeserializationContext, object>;
                    if (deserializeDelegate == null)
                    {
                        throw new InvalidOperationException("Could not get deserializer");
                    }

                    // Create deserialization context from request body
                    var deserializationContext = new GrpcDeserializationContext(context.Request.Body);
                    var request = deserializeDelegate(deserializationContext);

                    // Invoke the handler method
                    var response = await (Task<object>)handler.Invoke(service, new[] { request, serverCallContext });

                    // Get the marshaller for the response type
                    var responseMarshaller = method.GetType().GetField("ResponseMarshaller")?.GetValue(method) as Marshaller;
                    if (responseMarshaller == null)
                    {
                        throw new InvalidOperationException("Could not get response marshaller");
                    }

                    // Serialize the response
                    var serializeDelegate = responseMarshaller.GetType().GetProperty("ContextualSerializer")?.GetValue(responseMarshaller) as Action<object, SerializationContext>;
                    if (serializeDelegate == null)
                    {
                        throw new InvalidOperationException("Could not get serializer");
                    }

                    // Set response content type
                    context.Response.ContentType = "application/grpc";

                    // Create serialization context
                    var serializationContext = new GrpcSerializationContext(context.Response.Body);
                    serializeDelegate(response, serializationContext);

                    // Complete serialization
                    await serializationContext.CompleteAsync();
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsync(ex.Message);
                }
            });

            return endpoints;
        }

        private static ServerCallContext CreateServerCallContext(HttpContext httpContext)
        {
            // Create simple ServerCallContext implementation
            return new GrpcServerCallContext(httpContext);
        }

        #region Custom gRPC Context Implementations

        private class GrpcServerCallContext : ServerCallContext
        {
            private readonly HttpContext _httpContext;

            public GrpcServerCallContext(HttpContext httpContext)
            {
                _httpContext = httpContext;
            }

            protected override string MethodCore => _httpContext.Request.Path;
            protected override string HostCore => _httpContext.Request.Host.Value;
            protected override string PeerCore => _httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";
            protected override DateTime DeadlineCore => DateTime.MaxValue;
            protected override Metadata RequestHeadersCore => new Metadata();
            protected override CancellationToken CancellationTokenCore => _httpContext.RequestAborted;
            protected override Metadata ResponseTrailersCore => new Metadata();
            protected override Status StatusCore { get; set; } = Status.DefaultSuccess;
            protected override WriteOptions WriteOptionsCore { get; set; } = new WriteOptions();

            protected override AuthContext AuthContextCore => throw new NotImplementedException();

            protected override ContextPropagationToken CreatePropagationTokenCore(ContextPropagationOptions options)
            {
                throw new NotImplementedException();
            }

            protected override Task WriteResponseHeadersAsyncCore(Metadata responseHeaders)
            {
                return Task.CompletedTask;
            }
        }

        private class GrpcDeserializationContext : DeserializationContext
        {
            private readonly Stream _stream;

            public GrpcDeserializationContext(Stream stream)
            {
                _stream = stream;
            }

            public override int PayloadLength => -1; // Unknown length

            public override byte[] PayloadAsNewBuffer()
            {
                using var ms = new MemoryStream();
                _stream.CopyTo(ms);
                return ms.ToArray();
            }

            public override ReadOnlySequence<byte> PayloadAsReadOnlySequence()
            {
                return new ReadOnlySequence<byte>(PayloadAsNewBuffer());
            }
        }

        private class GrpcSerializationContext : SerializationContext
        {
            private readonly Stream _stream;

            public GrpcSerializationContext(Stream stream)
            {
                _stream = stream;
            }

            public override void Complete(byte[] payload)
            {
                _stream.Write(payload, 0, payload.Length);
            }

            public override Task CompleteAsync(byte[] payload)
            {
                return _stream.WriteAsync(payload, 0, payload.Length).AsTask();
            }

            public async Task CompleteAsync()
            {
                await _stream.FlushAsync();
            }

            public override IBufferWriter<byte> GetBufferWriter()
            {
                throw new NotImplementedException("Buffer writer not supported");
            }

            public override void SetPayloadLength(int payloadLength)
            {
                // No-op, not needed for direct stream writing
            }

            public override void Complete()
            {
                _stream.Flush();
            }
        }

        #endregion
    }
}
