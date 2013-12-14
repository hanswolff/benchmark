using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Collections
{
    class HashSetTests : BenchmarkFixture
    {
        const int Iterations = 2000000;

        [Test]
        public void Add_Int32()
        {
            var stopwatch = Stopwatch.StartNew();
            var hashSet = new HashSet<int>();
            for (var i = 0; i < Iterations; i++)
            {
                hashSet.Add(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Int64()
        {
            var stopwatch = Stopwatch.StartNew();
            var hashSet = new HashSet<long>();
            for (long i = 0; i < Iterations; i++)
            {
                hashSet.Add(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();

            var stopwatch = Stopwatch.StartNew();
            var hashtable = new HashSet<string>();
            for (var i = 0; i < Iterations; i++)
            {
                hashtable.Add(keys[i]);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Int32()
        {
            var enumerator = new HashSet<int>(Enumerable.Range(0, Iterations)).GetEnumerator();

            var stopwatch = Stopwatch.StartNew();
            while (enumerator.MoveNext()) { }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Int64()
        {
            var enumerator = new HashSet<long>(Enumerable.Range(0, Iterations).Select(x => (long)x)).GetEnumerator();

            var stopwatch = Stopwatch.StartNew();
            while (enumerator.MoveNext()) { }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_String()
        {
            var enumerator = new HashSet<string>(Enumerable.Range(0, Iterations).Select(x => x.ToString())).GetEnumerator();

            var stopwatch = Stopwatch.StartNew();
            while (enumerator.MoveNext()) { }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Int32()
        {
            var hashSet = new HashSet<int>(Enumerable.Range(0, Iterations));

            var stopwatch = Stopwatch.StartNew();
            while (hashSet.Count > 0) hashSet.Remove(hashSet.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Int64()
        {
            var hashSet = new HashSet<long>(Enumerable.Range(0, Iterations).Select(x => (long)x));

            var stopwatch = Stopwatch.StartNew();
            while (hashSet.Count > 0) hashSet.Remove(hashSet.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();
            var hashSet = new HashSet<string>(keys);

            var stopwatch = Stopwatch.StartNew();
            for (var i = Iterations - 1; i >= 0; i--)
            {
                hashSet.Remove(keys[i]);
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
