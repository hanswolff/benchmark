using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Benchmark.System.Theading
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class TaskTest
    {
        const int iterations = 5000;

        [Test]
        public void Task_WaitImmediatly()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                Task.Factory.StartNew(() => { }).Wait();
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Task_WaitLater()
        {
            var tasks = new List<Task>();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => { }));
            }
            Task.WaitAll(tasks.ToArray());
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Task_LongRunning_WaitImmediatly()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                Task.Factory.StartNew(() => { }, TaskCreationOptions.LongRunning).Wait();
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Task_LongRunning_WaitLater()
        {
            var tasks = new List<Task>();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => { }, TaskCreationOptions.LongRunning));
            }
            Task.WaitAll(tasks.ToArray());
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
