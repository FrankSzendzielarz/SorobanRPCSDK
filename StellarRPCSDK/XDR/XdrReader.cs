using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stellar.XDR
{
    /// <summary>
    /// Stream for reading XDR encoded data according to RFC 4506.
    /// Handles padding and alignment according to XDR specification.
    /// </summary>
    public class XdrReader
    {
        private readonly Stream _stream;
        private readonly byte[] _tempBuffer = new byte[8];

        public XdrReader(Stream stream)
        {
            _stream = stream;
        }

        public int ReadInt()
        {
            ReadExact(_tempBuffer, 0, 4);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(_tempBuffer, 0, 4);
            return BitConverter.ToInt32(_tempBuffer, 0);
        }

        public uint ReadUInt()
        {
            ReadExact(_tempBuffer, 0, 4);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(_tempBuffer, 0, 4);
            return BitConverter.ToUInt32(_tempBuffer, 0);
        }

        public long ReadLong()
        {
            ReadExact(_tempBuffer, 0, 8);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(_tempBuffer, 0, 8);
            return BitConverter.ToInt64(_tempBuffer, 0);
        }

        public ulong ReadULong()
        {
            ReadExact(_tempBuffer, 0, 8);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(_tempBuffer, 0, 8);
            return BitConverter.ToUInt64(_tempBuffer, 0);
        }

        public float ReadFloat()
        {
            ReadExact(_tempBuffer, 0, 4);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(_tempBuffer, 0, 4);
            return BitConverter.ToSingle(_tempBuffer, 0);
        }

        public double ReadDouble()
        {
            ReadExact(_tempBuffer, 0, 8);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(_tempBuffer, 0, 8);
            return BitConverter.ToDouble(_tempBuffer, 0);
        }

        public byte[] ReadOpaque()
        {
            var length = ReadInt();
            var data = new byte[length];
            ReadFixedOpaque(data);
            return data;
        }

        public void ReadFixedOpaque(byte[] data)
        {
            ReadExact(data, 0, data.Length);

            // Skip padding if needed
            var padding = (4 - (data.Length % 4)) % 4;
            if (padding > 0)
                Skip(padding);
        }

        public string ReadString()
        {
            var bytes = ReadOpaque();
            return Encoding.ASCII.GetString(bytes);
        }

        public void Skip(int count)
        {
            while (count > 0)
            {
                var skipped = _stream.Read(_tempBuffer, 0, Math.Min(count, _tempBuffer.Length));
                if (skipped == 0)
                    throw new EndOfStreamException();
                count -= skipped;
            }
        }

        private void ReadExact(byte[] buffer, int offset, int count)
        {
            while (count > 0)
            {
                var read = _stream.Read(buffer, offset, count);
                if (read == 0)
                    throw new EndOfStreamException();
                offset += read;
                count -= read;
            }
        }
    }
}
