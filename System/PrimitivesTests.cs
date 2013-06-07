using System;
using NUnit.Framework;
using System.Diagnostics;

namespace Benchmark.System
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class PrimitivesTests
    {
        const int iterations = 1000000;

        [Test]
        public void Int16_Addition()
        {
            var num = (short)new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
            }

            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Int16_Multiplication()
        {
            var num = (short)new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
            }

            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Int16_Division()
        {
            var num = (short)new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
            }

            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Int32_Addition()
        {
            var num = new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
            }

            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Int32_Multiplication()
        {
            var num = new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
            }

            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Int32_Division()
        {
            var num = new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
            }

            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Int64_Addition()
        {
            long num = new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
                num += 1;
            }

            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Int64_Multiplication()
        {
            long num = new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
            }

            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Int64_Division()
        {
            long num = new Random().Next(1);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
                num *= 3;
            }

            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
