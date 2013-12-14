using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Benchmark.System.Threading
{
    class TaskTests : BenchmarkFixture
    {
        const int Iterations = 5000;

        [Test]
        public void Task_WaitImmediatly()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                Task.Factory.StartNew(() => { }).Wait();
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Task_WaitLater()
        {
            var tasks = new List<Task>();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => { }));
            }
            Task.WaitAll(tasks.ToArray());
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Task_LongRunning_WaitImmediatly()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                Task.Factory.StartNew(() => { }, TaskCreationOptions.LongRunning).Wait();
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Task_LongRunning_WaitLater()
        {
            var tasks = new List<Task>();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => { }, TaskCreationOptions.LongRunning));
            }
            Task.WaitAll(tasks.ToArray());
            stopwatch.StopAndLog(Iterations);
        }
    }
}
