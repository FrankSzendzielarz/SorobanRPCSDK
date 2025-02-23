// Generated code - do not modify
// Source:

// union ContractExecutable switch (ContractExecutableType type)
// {
// case CONTRACT_EXECUTABLE_WASM:
//     Hash wasm_hash;
// case CONTRACT_EXECUTABLE_STELLAR_ASSET:
//     void;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(ContractExecutableWasm), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ContractExecutableStellarAsset), DataFormat = DataFormat.Default)]
    public abstract partial class ContractExecutable
    {
        public abstract ContractExecutableType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "ContractExecutable.ContractExecutableWasm")]
        public sealed partial class ContractExecutableWasm : ContractExecutable
        {
            public override ContractExecutableType Discriminator => ContractExecutableType.CONTRACT_EXECUTABLE_WASM;
            [ProtoMember(1)]
            public Hash wasm_hash
            {
                get => _wasm_hash;
                set
                {
                    _wasm_hash = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Wasm_hash")]
            #endif
            private Hash _wasm_hash;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ContractExecutable.ContractExecutableStellarAsset")]
        public sealed partial class ContractExecutableStellarAsset : ContractExecutable
        {
            public override ContractExecutableType Discriminator => ContractExecutableType.CONTRACT_EXECUTABLE_STELLAR_ASSET;

            public override void ValidateCase() {}
        }
    }
    public static partial class ContractExecutableXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractExecutable value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractExecutableXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ContractExecutable DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ContractExecutableXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, ContractExecutable value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ContractExecutable.ContractExecutableWasm case_CONTRACT_EXECUTABLE_WASM:
                HashXdr.Encode(stream, case_CONTRACT_EXECUTABLE_WASM.wasm_hash);
                break;
                case ContractExecutable.ContractExecutableStellarAsset case_CONTRACT_EXECUTABLE_STELLAR_ASSET:
                break;
            }
        }
        public static ContractExecutable Decode(XdrReader stream)
        {
            var discriminator = (ContractExecutableType)stream.ReadInt();
            switch (discriminator)
            {
                case ContractExecutableType.CONTRACT_EXECUTABLE_WASM:
                var result_CONTRACT_EXECUTABLE_WASM = new ContractExecutable.ContractExecutableWasm();
                result_CONTRACT_EXECUTABLE_WASM.wasm_hash = HashXdr.Decode(stream);
                return result_CONTRACT_EXECUTABLE_WASM;
                case ContractExecutableType.CONTRACT_EXECUTABLE_STELLAR_ASSET:
                var result_CONTRACT_EXECUTABLE_STELLAR_ASSET = new ContractExecutable.ContractExecutableStellarAsset();
                return result_CONTRACT_EXECUTABLE_STELLAR_ASSET;
                default:
                throw new Exception($"Unknown discriminator for ContractExecutable: {discriminator}");
            }
        }
    }
}
