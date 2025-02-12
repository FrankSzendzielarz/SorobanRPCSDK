// Generated code - do not modify
// Source:

// union SCError switch (SCErrorType type)
// {
// case SCE_CONTRACT:
//     uint32 contractCode;
// case SCE_WASM_VM:
// case SCE_CONTEXT:
// case SCE_STORAGE:
// case SCE_OBJECT:
// case SCE_CRYPTO:
// case SCE_EVENTS:
// case SCE_BUDGET:
// case SCE_VALUE:
// case SCE_AUTH:
//     SCErrorCode code;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class SCError
    {
        public abstract SCErrorType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class SceContract : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_CONTRACT;
            public uint32 contractCode
            {
                get => _contractCode;
                set
                {
                    _contractCode = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Code")]
            #endif
            private uint32 _contractCode;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceWasmVm : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_WASM_VM;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceContext : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_CONTEXT;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceStorage : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_STORAGE;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceObject : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_OBJECT;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceCrypto : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_CRYPTO;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceEvents : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_EVENTS;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceBudget : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_BUDGET;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceValue : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_VALUE;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SceAuth : SCError
        {
            public override SCErrorType Discriminator => SCErrorType.SCE_AUTH;
            public SCErrorCode code
            {
                get => _code;
                set
                {
                    _code = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Code")]
            #endif
            private SCErrorCode _code;

            public override void ValidateCase() {}
        }
    }
    public static partial class SCErrorXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCError value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCErrorXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCError value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCError.SceContract case_SCE_CONTRACT:
                uint32Xdr.Encode(stream, case_SCE_CONTRACT.contractCode);
                break;
                case SCError.SceWasmVm case_SCE_WASM_VM:
                SCErrorCodeXdr.Encode(stream, case_SCE_WASM_VM.code);
                break;
                case SCError.SceContext case_SCE_CONTEXT:
                SCErrorCodeXdr.Encode(stream, case_SCE_CONTEXT.code);
                break;
                case SCError.SceStorage case_SCE_STORAGE:
                SCErrorCodeXdr.Encode(stream, case_SCE_STORAGE.code);
                break;
                case SCError.SceObject case_SCE_OBJECT:
                SCErrorCodeXdr.Encode(stream, case_SCE_OBJECT.code);
                break;
                case SCError.SceCrypto case_SCE_CRYPTO:
                SCErrorCodeXdr.Encode(stream, case_SCE_CRYPTO.code);
                break;
                case SCError.SceEvents case_SCE_EVENTS:
                SCErrorCodeXdr.Encode(stream, case_SCE_EVENTS.code);
                break;
                case SCError.SceBudget case_SCE_BUDGET:
                SCErrorCodeXdr.Encode(stream, case_SCE_BUDGET.code);
                break;
                case SCError.SceValue case_SCE_VALUE:
                SCErrorCodeXdr.Encode(stream, case_SCE_VALUE.code);
                break;
                case SCError.SceAuth case_SCE_AUTH:
                SCErrorCodeXdr.Encode(stream, case_SCE_AUTH.code);
                break;
            }
        }
        public static SCError Decode(XdrReader stream)
        {
            var discriminator = (SCErrorType)stream.ReadInt();
            switch (discriminator)
            {
                case SCErrorType.SCE_CONTRACT:
                var result_SCE_CONTRACT = new SCError.SceContract();
                result_SCE_CONTRACT.contractCode = uint32Xdr.Decode(stream);
                return result_SCE_CONTRACT;
                case SCErrorType.SCE_WASM_VM:
                var result_SCE_WASM_VM = new SCError.SceWasmVm();
                result_SCE_WASM_VM.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_WASM_VM;
                case SCErrorType.SCE_CONTEXT:
                var result_SCE_CONTEXT = new SCError.SceContext();
                result_SCE_CONTEXT.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_CONTEXT;
                case SCErrorType.SCE_STORAGE:
                var result_SCE_STORAGE = new SCError.SceStorage();
                result_SCE_STORAGE.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_STORAGE;
                case SCErrorType.SCE_OBJECT:
                var result_SCE_OBJECT = new SCError.SceObject();
                result_SCE_OBJECT.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_OBJECT;
                case SCErrorType.SCE_CRYPTO:
                var result_SCE_CRYPTO = new SCError.SceCrypto();
                result_SCE_CRYPTO.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_CRYPTO;
                case SCErrorType.SCE_EVENTS:
                var result_SCE_EVENTS = new SCError.SceEvents();
                result_SCE_EVENTS.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_EVENTS;
                case SCErrorType.SCE_BUDGET:
                var result_SCE_BUDGET = new SCError.SceBudget();
                result_SCE_BUDGET.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_BUDGET;
                case SCErrorType.SCE_VALUE:
                var result_SCE_VALUE = new SCError.SceValue();
                result_SCE_VALUE.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_VALUE;
                case SCErrorType.SCE_AUTH:
                var result_SCE_AUTH = new SCError.SceAuth();
                result_SCE_AUTH.code = SCErrorCodeXdr.Decode(stream);
                return result_SCE_AUTH;
                default:
                throw new Exception($"Unknown discriminator for SCError: {discriminator}");
            }
        }
    }
}
