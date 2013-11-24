using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Benchmark.System
{
    [TestFixture]
    public class BitConverterTests
    {
        const int Iterations = 2000000;

        [Test]
        public void GetBytes_ShortValue()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                BitConverter.GetBytes((short)0);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void GetBytes_IntValue()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                BitConverter.GetBytes(0);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void GetBytes_LongValue()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                BitConverter.GetBytes(0L);
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
