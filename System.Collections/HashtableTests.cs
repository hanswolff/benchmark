using NUnit.Framework;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Collections
{
    class HashtableTests : BenchmarkFixture
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
        public void Add_Key_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();

            var stopwatch = Stopwatch.StartNew();
            var hashtable = new Hashtable();
            for (long i = 0; i < Iterations; i++)
            {
                hashtable.Add(keys[i], null);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyDoesntExist_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x));

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
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            for (long i = -1; i >= -Iterations; i--)
            {
                hashtable.ContainsKey(-1);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyDoesntExist_String()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x.ToString()));

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                hashtable.ContainsKey("");
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyExists_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x));

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
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                hashtable.ContainsKey(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ContainsKey_KeyExists_String()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x.ToString()));

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                hashtable.ContainsKey("0");
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Get_Key_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var value = (int)hashtable[i];
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Get_Key_Int64()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                var value = (long)hashtable[i];
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Get_Key_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();
            var hashtable = new Hashtable(keys.ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var value = (string)hashtable[keys[i]];
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in hashtable)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_Int64()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in hashtable)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Key_String()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x.ToString()));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in hashtable)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            for (var i = Iterations - 1; i >= 0; i--)
            {
                hashtable.Remove(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_Int64()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            for (long i = Iterations - 1; i >= 0; i--)
            {
                hashtable.Remove(i);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Key_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();
            var hashtable = new Hashtable(keys.ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            for (var i = Iterations - 1; i >= 0; i--)
            {
                hashtable.Remove(keys[i]);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Set_Key_Int32()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                hashtable[i] = i;
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Set_Key_Int64()
        {
            var hashtable = new Hashtable(Enumerable.Range(0, Iterations).Select(x => (long)x).ToDictionary(x => x));

            var stopwatch = Stopwatch.StartNew();
            for (long i = 0; i < Iterations; i++)
            {
                hashtable[i] = i;
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Set_Key_String()
        {
            var keys = Enumerable.Range(0, Iterations).Select(x => x.ToString()).ToArray();
            var hashtable = new Hashtable(keys.ToDictionary(x => x, null));

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var key = keys[i];
                hashtable[key] = key;
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
