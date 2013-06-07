using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Benchmark.System.Collections
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class HashSetTest
    {
        const int iterations = 2000000;

        [Test]
        public void Add_Int32()
        {
            var stopwatch = Stopwatch.StartNew();
            var hashSet = new HashSet<int>();
            for (var i = 0; i < iterations; i++)
            {
                hashSet.Add(i);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Add_Int64()
        {
            var stopwatch = Stopwatch.StartNew();
            var hashSet = new HashSet<long>();
            for (long i = 0; i < iterations; i++)
            {
                hashSet.Add(i);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void ForEach_Int32()
        {
            var list = new HashSet<int>(Enumerable.Range(0, iterations));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void ForEach_Int64()
        {
            var list = new HashSet<long>(Enumerable.Range(0, iterations).Select(x => (long)x));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void RemoveLast_Int32()
        {
            var list = new HashSet<int>(Enumerable.Range(0, iterations));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.Remove(list.Count - 1);
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void RemoveLast_Int64()
        {
            var list = new HashSet<long>(Enumerable.Range(0, iterations).Select(x => (long)x));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.Remove(list.Count - 1);
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
