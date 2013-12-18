using NUnit.Framework;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    class MonitorTests : BenchmarkFixture
    {
        const int Iterations = 10000000;

        [Test]
        public void Lock()
        {
            var lockObject = new object();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                lock (lockObject)
                {
                }
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void MonitorEnterExit()
        {
            var lockObject = new object();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                Monitor.Enter(lockObject);
                Monitor.Exit(lockObject);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void MonitorTryEnterExit()
        {
            var lockObject = new object();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                Monitor.TryEnter(lockObject);
                Monitor.Exit(lockObject);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void MonitorTryEnter_LockTaken()
        {
            var lockObject = new object();

            lock (lockObject)
            {
                var stopwatch = Stopwatch.StartNew();
                for (var i = 0; i < Iterations; i++)
                {
                    var lockTaken = false;
                    Monitor.TryEnter(lockObject, ref lockTaken);
                }
                stopwatch.StopAndLog(Iterations);
            }
        }
    }
}
