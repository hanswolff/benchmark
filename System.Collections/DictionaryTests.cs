﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Collections
{
    class DictionaryTests : BenchmarkFixture
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
        public void Add_Key_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();

            var stopwatch = Stopwatch.StartNew();
            var dictionary = new Dictionary<string, object>();
            for (long i = 0; i < Iterations; i++)
            {
                dictionary.Add(keys[i], null);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyDoesntExist_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x);

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
            var dictionary = Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (long i = -1; i >= -Iterations; i--)
            {
                dictionary.ContainsKey(-1);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyDoesntExist_String()
        {
            var dictionary = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                dictionary.ContainsKey("");
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyExists_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x);

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
            var dictionary = Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                dictionary.ContainsKey(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyExists_String()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x.ToString());

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                dictionary.ContainsKey("0");
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Get_Key_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var value = dictionary[i];
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Get_Key_Int64()
        {
            var dictionary = Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                var value = dictionary[i];
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Get_Key_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();
            var dictionary = keys.ToDictionary(x => x, null);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var value = dictionary[keys[i]];
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in dictionary)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int64()
        {
            var dictionary = Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in dictionary)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_String()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x.ToString());

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in dictionary)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (var i = Iterations - 1; i >= 0; i--)
            {
                dictionary.Remove(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_Int64()
        {
            var dictionary = Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (long i = Iterations - 1; i >= 0; i--)
            {
                dictionary.Remove(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();
            var dictionary = keys.ToDictionary(x => x, null);

            var stopwatch = Stopwatch.StartNew();
            for (var i = Iterations - 1; i >= 0; i--)
            {
                dictionary.Remove(keys[i]);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Set_Key_Int32()
        {
            var dictionary = Enumerable.Range(0, Iterations).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                dictionary[i] = i;
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Set_Key_Int64()
        {
            var dictionary = Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x);

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                dictionary[i] = i;
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Set_Key_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();
            var dictionary = keys.ToDictionary(x => x, null);

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var key = keys[i];
                dictionary[key] = key;
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
