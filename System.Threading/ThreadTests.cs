using NUnit.Framework;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    class ThreadTests : BenchmarkFixture
    {
        const int Iterations = 1000;

        [Test]
        public void Thread_Start_Join()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var thread = new Thread(() => { });
                thread.Start();
                thread.Join();
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
