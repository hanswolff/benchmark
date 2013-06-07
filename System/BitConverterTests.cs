using System;
using System.Diagnostics;
using NUnit.Framework;

namespace Benchmark.System
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class BitConverterTests
    {
        const int iterations = 2000000;

        [Test]
        public void GetBytes_ShortValue()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                BitConverter.GetBytes((short)0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void GetBytes_IntValue()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                BitConverter.GetBytes(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void GetBytes_LongValue()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                BitConverter.GetBytes(0L);
            }
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
