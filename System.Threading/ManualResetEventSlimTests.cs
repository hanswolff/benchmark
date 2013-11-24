using NUnit.Framework;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    [TestFixture]
    public class ManualResetEventSlimTests
    {
        const int Iterations = 1000000;

        [Test]
        public void CreationDestruction()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                using (new ManualResetEventSlim(false))
                {
                }
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Set_Reset_Cycles()
        {
            using (var resetEvent = new ManualResetEventSlim(false))
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
            using (var resetEvent = new ManualResetEventSlim(true))
            {
                var stopwatch = Stopwatch.StartNew();

                for (var i = 0; i < Iterations; i++)
                {
                    resetEvent.Wait(0);
                }
                stopwatch.StopAndLog(Iterations);
            }
        }
    }
}
