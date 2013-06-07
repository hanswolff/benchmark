using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Benchmark.System.Collections
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class ConcurrentStackTest
    {
        const int iterations = 1000000;

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(1, 2)]
        [TestCase(4, 1)]
        [TestCase(1, 4)]
        [TestCase(2, 2)]
        [TestCase(4, 4)]
        public void PushTryPop(int producerThreads, int consumerThreads)
        {
            var stack = new ConcurrentStack<int>();
            var startEvent = new ManualResetEventSlim(false);
            var finished = 0;
            var stop = false;
            var producerTasks = Enumerable.Range(0, producerThreads).Select(i => Task.Factory.StartNew(() =>
                {
                    var count = iterations/producerThreads;
                    startEvent.Wait();
                    for (var j = 0; j < count; j++)
                        stack.Push(0);
                    Interlocked.Increment(ref finished);
                    if (finished >= producerThreads) stop = true;
                }, TaskCreationOptions.LongRunning)).ToArray();
            var consumerTasks = Enumerable.Range(0, consumerThreads).Select(i => Task.Factory.StartNew(() =>
                {
                    int num;
                    startEvent.Wait();
                    while (!stop) stack.TryPop(out num);
                }, TaskCreationOptions.LongRunning)).ToArray();

            var stopwatch = Stopwatch.StartNew();
            startEvent.Set();
            stop = true;
            Task.WaitAll(producerTasks);
            Task.WaitAll(consumerTasks);
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
