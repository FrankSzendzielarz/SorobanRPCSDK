using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.CodeGenVisitors
{
    public class XdrSpecialTypeHandler
    {
        // Opaque data handling - fixed length
        public static void EncodeOpaque(XdrDataOutputStream stream, byte[] value, int fixedLength)
        {
            if (value.Length != fixedLength)
                throw new ArgumentException($"Fixed opaque data must be exactly {fixedLength} bytes");

            stream.Write(value, 0, fixedLength);

            // XDR requires padding to 4-byte boundary
            var padding = (4 - (fixedLength % 4)) % 4;
            for (int i = 0; i < padding; i++)
                stream.Write((byte)0);
        }

        // Opaque data handling - variable length
        public static void EncodeOpaque(XdrDataOutputStream stream, byte[] value, int? maxLength = null)
        {
            if (maxLength.HasValue && value.Length > maxLength.Value)
                throw new ArgumentException($"Variable opaque data cannot exceed {maxLength.Value} bytes");

            stream.WriteInt(value.Length);
            stream.Write(value, 0, value.Length);

            // XDR requires padding to 4-byte boundary
            var padding = (4 - (value.Length % 4)) % 4;
            for (int i = 0; i < padding; i++)
                stream.Write((byte)0);
        }

        public static byte[] DecodeOpaque(XdrDataInputStream stream, int fixedLength)
        {
            var value = new byte[fixedLength];
            stream.Read(value, 0, fixedLength);

            // Skip padding
            var padding = (4 - (fixedLength % 4)) % 4;
            stream.Skip(padding);

            return value;
        }

        public static byte[] DecodeOpaque(XdrDataInputStream stream, int? maxLength = null)
        {
            var length = stream.ReadInt();
            if (maxLength.HasValue && length > maxLength.Value)
                throw new ArgumentException($"Variable opaque data exceeds maximum length of {maxLength.Value}");

            var value = new byte[length];
            stream.Read(value, 0, length);

            // Skip padding
            var padding = (4 - (length % 4)) % 4;
            stream.Skip(padding);

            return value;
        }

        // String handling
        public static void EncodeString(XdrDataOutputStream stream, string value, int maxLength)
        {
            if (value.Length > maxLength)
                throw new ArgumentException($"String length exceeds maximum of {maxLength}");

            var bytes = System.Text.Encoding.UTF8.GetBytes(value);
            EncodeOpaque(stream, bytes); // Uses variable length opaque encoding
        }

        public static string DecodeString(XdrDataInputStream stream, int maxLength)
        {
            var bytes = DecodeOpaque(stream);
            if (bytes.Length > maxLength)
                throw new ArgumentException($"Decoded string length exceeds maximum of {maxLength}");

            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        // Optional field handling
        public static void EncodeOptional<T>(XdrDataOutputStream stream, T? value, Action<XdrDataOutputStream, T> encodeFunc)
            where T : class
        {
            if (value != null)
            {
                stream.WriteInt(1);
                encodeFunc(stream, value);
            }
            else
            {
                stream.WriteInt(0);
            }
        }

        public static void EncodeOptional<T>(XdrDataOutputStream stream, T? value, Action<XdrDataOutputStream, T> encodeFunc)
            where T : struct
        {
            if (value.HasValue)
            {
                stream.WriteInt(1);
                encodeFunc(stream, value.Value);
            }
            else
            {
                stream.WriteInt(0);
            }
        }

        public static T? DecodeOptional<T>(XdrDataInputStream stream, Func<XdrDataInputStream, T> decodeFunc)
            where T : class
        {
            var present = stream.ReadInt();
            return present != 0 ? decodeFunc(stream) : null;
        }

       

        // Helper method for getting the C# type for special XDR types
        public static string GetSpecialTypeCSharp(XdrSpecialType type, int? length = null)
        {
            return type switch
            {
                XdrSpecialType.Opaque => "byte[]",
                XdrSpecialType.String => "string",
                XdrSpecialType.Optional => throw new ArgumentException("Optional types need their internal type specified"),
                _ => throw new ArgumentException($"Unknown special type: {type}")
            };
        }
    }

    public enum XdrSpecialType
    {
        Opaque,
        String,
        Optional
    }

   
}
