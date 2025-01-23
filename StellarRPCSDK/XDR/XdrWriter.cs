using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StellarRPCSDK.XDR
{
    /// <summary>
    /// Stream for writing XDR encoded data according to RFC 4506.
    /// Handles padding and alignment according to XDR specification.
    /// </summary>
    public class XdrWriter
    {
        private readonly Stream _stream;
        private readonly byte[] _padding = new byte[4];
        private readonly byte[] _tempBuffer = new byte[8];

        public XdrWriter(Stream stream)
        {
            _stream = stream;
        }

        public void WriteInt(int value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            _stream.Write(bytes, 0, 4);
        }

        public void WriteUInt(uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            _stream.Write(bytes, 0, 4);
        }

        public void WriteLong(long value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            _stream.Write(bytes, 0, 8);
        }

        public void WriteULong(ulong value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            _stream.Write(bytes, 0, 8);
        }

        public void WriteFloat(float value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            _stream.Write(bytes, 0, 4);
        }

        public void WriteDouble(double value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            _stream.Write(bytes, 0, 8);
        }

        public void WriteOpaque(byte[] data)
        {
            WriteInt(data.Length);
            WriteFixedOpaque(data);
        }

        public void WriteFixedOpaque(byte[] data)
        {
            _stream.Write(data, 0, data.Length);

            // Write padding if needed
            var padding = (4 - (data.Length % 4)) % 4;
            if (padding > 0)
                _stream.Write(_padding, 0, padding);
        }

        public void WriteString(string value)
        {
            var bytes = Encoding.UTF8.GetBytes(value);
            WriteOpaque(bytes);
        }

        public void Flush()
        {
            _stream.Flush();
        }
    }

}
