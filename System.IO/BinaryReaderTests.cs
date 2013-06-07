using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace Benchmark.System.IO
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class BinaryReaderTests
    {
        const int iterations = 2000000;

        [Test]
        public void ReadInt16()
        {
            var buf = new byte[sizeof(short) * iterations];
            using (var mem = new MemoryStream(buf))
            using (var reader = new BinaryReader(mem))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < iterations; i++)
                {
                    reader.ReadInt16();
                }
                stopwatch.StopAndLog(iterations);
            }
        }

        [Test]
        public void ReadInt32()
        {
            var buf = new byte[sizeof(int) * iterations];
            using (var mem = new MemoryStream(buf))
            using (var reader = new BinaryReader(mem))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < iterations; i++)
                {
                    reader.ReadInt32();
                }
                stopwatch.StopAndLog(iterations);
            }
        }

        [Test]
        public void ReadInt64()
        {
            var buf = new byte[sizeof(long) * iterations];
            using (var mem = new MemoryStream(buf))
            using (var reader = new BinaryReader(mem))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < iterations; i++)
                {
                    reader.ReadInt64();
                }
                stopwatch.StopAndLog(iterations);
            }
        }

        [Test]
        public void Read_BitConverter_ToInt16()
        {
            var buf = new byte[sizeof(short)];
            using (var mem = new MemoryStream(new byte[sizeof(short) * iterations]))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < iterations; i++)
                {
                    mem.Read(buf, 0, buf.Length);
                    BitConverter.ToInt16(buf, 0);
                }
                stopwatch.StopAndLog(iterations);
            }
        }

        [Test]
        public void Read_BitConverter_ToInt32()
        {
            var buf = new byte[sizeof(int)];
            using (var mem = new MemoryStream(new byte[sizeof(int) * iterations]))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < iterations; i++)
                {
                    mem.Read(buf, 0, buf.Length);
                    BitConverter.ToInt32(buf, 0);
                }
                stopwatch.StopAndLog(iterations);
            }
        }

        [Test]
        public void Read_BitConverter_ToInt64()
        {
            var buf = new byte[sizeof(long)];
            using (var mem = new MemoryStream(new byte[sizeof(long) * iterations]))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < iterations; i++)
                {
                    mem.Read(buf, 0, buf.Length);
                    BitConverter.ToInt64(buf, 0);
                }
                stopwatch.StopAndLog(iterations);
            }
        }
    }
    // ReSharper restore InconsistentNaming
}
