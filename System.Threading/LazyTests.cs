using System.Linq;
using System.Threading;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Benchmark.System.Threading
{
    class LazyTests : BenchmarkFixture
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
        public void Lazy_Value_Initialized()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            var array = Enumerable.Range(0, Iterations).Select(i => new Lazy<int>(() => i)).ToArray();
            foreach (var lazy in array)
            {
                var dummy = lazy.Value;
            }

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var num = array[i].Value;
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Lazy_Value_NotInitialized()
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
        public void LazyInitializer_EnsureInitialized_Initialized()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            var array = Enumerable.Range(0, Iterations).Select(i => (object)i).ToArray();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                LazyInitializer.EnsureInitialized(ref array[i], () => "");
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void LazyInitializer_EnsureInitialized_NotInitialized()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            var array = Enumerable.Range(0, Iterations).Select(i => (object)null).ToArray();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                LazyInitializer.EnsureInitialized(ref array[i], () => "");
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
