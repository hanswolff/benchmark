using NUnit.Framework;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    class SemaphoreSlimTests : BenchmarkFixture
    {
        const int Iterations = 1000000;

        [Test]
        public void CreationDestruction()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                using (new SemaphoreSlim(2, 2))
                {
                }
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void WaitRelease()
        {
            using (var semaphore = new SemaphoreSlim(2, 2))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    semaphore.Wait();
                    semaphore.Release();
                }
                stopwatch.StopAndLog(Iterations);
            }
        }
    }
}
