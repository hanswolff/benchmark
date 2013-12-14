using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Benchmark.System
{
    [TestFixture]
    public class PrimitivesTests
    {
        const int Iterations = 10000000;

        [Test]
        public void Int16_Addition()
        {
            var num = (short)0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num += 1;
            }
            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Int16_Multiplication()
        {
            var num = (short)0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num *= 3;
            }
            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Int16_Division()
        {
            var num = (short)0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num *= 3;
            }
            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Int32_Addition()
        {
            var num = 0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num += 1;
            }
            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Int32_Multiplication()
        {
            var num = 0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num *= 3;
            }
            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Int32_Division()
        {
            var num = 0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num *= 3;
            }

            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Int64_Addition()
        {
            long num = 0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num += 1;
            }
            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Int64_Multiplication()
        {
            long num = 0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num *= 3;
            }
            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Int64_Division()
        {
            long num = 0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                num *= 3;
            }
            stopwatch.StopAndLog(Iterations);

            if (num == 0) NeverCalled();
        }

        [Test]
        public void Guid_NewGuid()
        {
            var guid = Guid.NewGuid();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                guid = Guid.NewGuid();
            }
            stopwatch.StopAndLog(Iterations);

            if (guid == Guid.Empty) NeverCalled();
        }

        private static void NeverCalled()
        {
            Console.WriteLine("Optimization must keep loop content");
        }
    }
}
