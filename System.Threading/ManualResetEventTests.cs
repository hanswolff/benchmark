using NUnit.Framework;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    class ManualResetEventTests : BenchmarkFixture
    {
        const int Iterations = 100000;

        [Test]
        public void CreationDestruction()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                using (new ManualResetEvent(false))
                {
                }
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Set_Reset_Cycles()
        {
            using (var resetEvent = new ManualResetEvent(false))
            {
                var stopwatch = Stopwatch.StartNew();

                for (var i = 0; i < Iterations; i++)
                {
                    resetEvent.Set();
                    resetEvent.Reset();
                }
                stopwatch.StopAndLog(Iterations);
            }
        }

        [Test]
        public void WaitOne_AlreadySet()
        {
            using (var resetEvent = new ManualResetEvent(true))
            {
                var stopwatch = Stopwatch.StartNew();

                for (var i = 0; i < Iterations; i++)
                {
                    resetEvent.WaitOne(0);
                }
                stopwatch.StopAndLog(Iterations);
            }
        }
    }
}
