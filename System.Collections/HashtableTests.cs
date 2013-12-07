using NUnit.Framework;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Collections
{
    [TestFixture]
    public class HashtableTests
    {
        const int Iterations = 2000000;

        [Test]
        public void Add_Key_Int32()
        {
            var stopwatch = Stopwatch.StartNew();
            var hashSet = new Hashtable();
            for (var i = 0; i < Iterations; i++)
            {
                hashSet.Add(i, null);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Key_Int64()
        {
            var stopwatch = Stopwatch.StartNew();
            var hashSet = new Hashtable();
            for (long i = 0; i < Iterations; i++)
            {
                hashSet.Add(i, null);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int32()
        {
            var list = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int64()
        {
            var list = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_Int32()
        {
            var list = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.Remove(list.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_Int64()
        {
            var list = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.Remove(list.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }
    }
}
