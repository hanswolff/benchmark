using NUnit.Framework;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class ThreadTest
    {
        const int iterations = 1000;

        [Test]
        public void Thread_Start_Join()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var thread = new Thread(() => { });
                thread.Start();
                thread.Join();
            }
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
