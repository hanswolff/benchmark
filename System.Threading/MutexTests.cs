using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    class MutexTests : BenchmarkFixture
    {
        const int Iterations = 100000;

        [Test]
        public void CreationDestruction()
        {
            var name = Guid.NewGuid().ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                using (new Mutex(true, name))
                {
                }
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void WaitRelease()
        {
            var name = Guid.NewGuid().ToString();
            using (var mutex = new Mutex(true, name))
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    mutex.WaitOne();
                    mutex.ReleaseMutex();
                }
                stopwatch.StopAndLog(Iterations);
            }
        }
    }
}
