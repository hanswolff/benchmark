using System.Linq;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Benchmark.System.Threading
{
    [TestFixture]
    public class LazyTests
    {
        const int Iterations = 1000000;

        [Test]
        public void NewInstance()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var lazy = new Lazy<int>();
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void LazyEvaluation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            var array = Enumerable.Range(0, Iterations).Select(i => new Lazy<int>(() => i)).ToArray();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var num = array[i].Value;
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void IsValueCreated()
        {
            var array = Enumerable.Range(0, Iterations).Select(i => new Lazy<int>(() => i)).ToArray();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var b = array[i].IsValueCreated;
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
