using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Collections
{
    [TestFixture]
    public class DictionaryTests
    {
        const int Iterations = 2000000;

        [Test]
        public void Add_Key_Int32()
        {
            var stopwatch = Stopwatch.StartNew();
            var dictionary = new Dictionary<int, object>();
            for (var i = 0; i < Iterations; i++)
            {
                dictionary.Add(i, null);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Key_Int64()
        {
            var stopwatch = Stopwatch.StartNew();
            var dictionary = new Dictionary<long, object>();
            for (long i = 0; i < Iterations; i++)
            {
                dictionary.Add(i, null);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyDoesntExist_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x, null);

            var stopwatch = Stopwatch.StartNew();
            for (var i = -1; i >= -Iterations; i--)
            {
                dictionary.ContainsKey(-1);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyDoesntExist_Int64()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => (long)x, null);

            var stopwatch = Stopwatch.StartNew();
            for (long i = -1; i >= -Iterations; i--)
            {
                dictionary.ContainsKey(-1);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyExists_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x, null);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                dictionary.ContainsKey(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyExists_Int64()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => (long)x, null);

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                dictionary.ContainsKey(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x, null);

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in dictionary)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int64()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => (long)x, null);

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in dictionary)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x, null);

            var stopwatch = Stopwatch.StartNew();
            while (dictionary.Count > 0) dictionary.Remove(dictionary.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_Int64()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => (long)x, null);

            var stopwatch = Stopwatch.StartNew();
            while (dictionary.Count > 0) dictionary.Remove((long)dictionary.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }
    }
}
