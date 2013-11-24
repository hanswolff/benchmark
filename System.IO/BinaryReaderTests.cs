using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;

namespace Benchmark.System.IO
{
    [TestFixture]
    public class BinaryReaderTests
    {
        const int Iterations = 2000000;

        [Test]
        public void ReadInt16()
        {
            var buf = new byte[sizeof(short) * Iterations];
            using (var mem = new MemoryStream(buf))
            using (var reader = new BinaryReader(mem))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    reader.ReadInt16();
                }
                stopwatch.StopAndLog(Iterations);
            }
        }

        [Test]
        public void ReadInt32()
        {
            var buf = new byte[sizeof(int) * Iterations];
            using (var mem = new MemoryStream(buf))
            using (var reader = new BinaryReader(mem))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    reader.ReadInt32();
                }
                stopwatch.StopAndLog(Iterations);
            }
        }

        [Test]
        public void ReadInt64()
        {
            var buf = new byte[sizeof(long) * Iterations];
            using (var mem = new MemoryStream(buf))
            using (var reader = new BinaryReader(mem))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    reader.ReadInt64();
                }
                stopwatch.StopAndLog(Iterations);
            }
        }

        [Test]
        public void Read_BitConverter_ToInt16()
        {
            var buf = new byte[sizeof(short)];
            using (var mem = new MemoryStream(new byte[sizeof(short) * Iterations]))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    mem.Read(buf, 0, buf.Length);
                    BitConverter.ToInt16(buf, 0);
                }
                stopwatch.StopAndLog(Iterations);
            }
        }

        [Test]
        public void Read_BitConverter_ToInt32()
        {
            var buf = new byte[sizeof(int)];
            using (var mem = new MemoryStream(new byte[sizeof(int) * Iterations]))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    mem.Read(buf, 0, buf.Length);
                    BitConverter.ToInt32(buf, 0);
                }
                stopwatch.StopAndLog(Iterations);
            }
        }

        [Test]
        public void Read_BitConverter_ToInt64()
        {
            var buf = new byte[sizeof(long)];
            using (var mem = new MemoryStream(new byte[sizeof(long) * Iterations]))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    mem.Read(buf, 0, buf.Length);
                    BitConverter.ToInt64(buf, 0);
                }
                stopwatch.StopAndLog(Iterations);
            }
        }
    }
}
