using NUnit.Framework;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    [TestFixture]
    public class SemaphoreTests
    {
        const int Iterations = 100000;

        [Test]
        public void CreationDestruction()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                using (new Semaphore(2, 2))
                {
                }
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void WaitRelease()
        {
            using (var semaphore = new Semaphore(2, 2))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    semaphore.WaitOne();
                    semaphore.Release();
                }
                stopwatch.StopAndLog(Iterations);
            }
        }
    }
}
