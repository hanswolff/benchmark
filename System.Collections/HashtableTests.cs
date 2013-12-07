using NUnit.Framework;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Collections
{
    [TestFixture]
    public class HashtableTests
    {
        const int Iterations = 1000000;

        [Test]
        public void Add_Key_Int32()
        {
            var stopwatch = Stopwatch.StartNew();
            var hashtable = new Hashtable();
            for (var i = 0; i < Iterations; i++)
            {
                hashtable.Add(i, null);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Key_Int64()
        {
            var stopwatch = Stopwatch.StartNew();
            var hashtable = new Hashtable();
            for (long i = 0; i < Iterations; i++)
            {
                hashtable.Add(i, null);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyDoesntExist_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            for (var i = -1; i >= -Iterations; i--)
            {
                hashtable.ContainsKey(-1);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyDoesntExist_Int64()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => (long)x, null));

            var stopwatch = Stopwatch.StartNew();
            for (long i = -1; i >= -Iterations; i--)
            {
                hashtable.ContainsKey(-1);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyExists_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                hashtable.ContainsKey(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyExists_Int64()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => (long)x, null));

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                hashtable.ContainsKey(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in hashtable)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int64()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => (long)x, null));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in hashtable)
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
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => (long)x, null));

            var stopwatch = Stopwatch.StartNew();
            while (hashtable.Count > 0) hashtable.Remove((long)hashtable.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }

    }
}
