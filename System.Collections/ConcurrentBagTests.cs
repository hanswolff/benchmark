using NUnit.Framework;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Benchmark.System.Collections
{
    class ConcurrentBagTests : BenchmarkFixture
    {
        const int Iterations = 1000000;

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(1, 2)]
        [TestCase(4, 1)]
        [TestCase(1, 4)]
        [TestCase(2, 2)]
        [TestCase(4, 4)]
        public void PushTryPop(int producerThreads, int consumerThreads)
        {
            var bag = new ConcurrentBag<int>();
            var startEvent = new ManualResetEventSlim(false);
            var finished = 0;
            var stop = false;
            var producerTasks = Enumerable.Range(0, producerThreads).Select(i => Task.Factory.StartNew(() =>
                {
                    var count = Iterations/producerThreads;
                    startEvent.Wait();
                    for (var j = 0; j < count; j++)
                        bag.Add(0);
                    Interlocked.Increment(ref finished);
                    if (finished >= producerThreads) stop = true;
                }, TaskCreationOptions.LongRunning)).ToArray();
            var consumerTasks = Enumerable.Range(0, consumerThreads).Select(i => Task.Factory.StartNew(() =>
                {
                    int num;
                    startEvent.Wait();
                    while (!stop) bag.TryTake(out num);
                }, TaskCreationOptions.LongRunning)).ToArray();

            var stopwatch = Stopwatch.StartNew();
            startEvent.Set();
            stop = true;
            Task.WaitAll(producerTasks);
            Task.WaitAll(consumerTasks);
            stopwatch.StopAndLog(Iterations);
        }
    }
}
