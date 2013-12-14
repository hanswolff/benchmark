using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Collections
{
    class ListTests : BenchmarkFixture
    {
        const int Iterations = 2000000;

        [Test]
        public void Add_Byte_Without_Preinitialization()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<byte>();
            for (var i = 0; i < Iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Byte_Preinitialized()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<byte>(Iterations);
            for (var i = 0; i < Iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Int32_Without_Preinitialization()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<int>();
            for (var i = 0; i < Iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Int32_Preinitialized()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<int>(Iterations);
            for (var i = 0; i < Iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Int64_Without_Preinitialization()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<long>();
            for (long i = 0; i < Iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Add_Int64_Preinitialized()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<long>(Iterations);
            for (long i = 0; i < Iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Byte()
        {
            var list = new List<byte>(Enumerable.Range(0, Iterations).Select(x => (byte)0));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Int32()
        {
            var list = new List<int>(Enumerable.Range(0, Iterations).Select(x => 0));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void ForEach_Int64()
        {
            var list = new List<long>(Enumerable.Range(0, Iterations).Select(x => 0L));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Byte()
        {
            var list = new List<byte>(Enumerable.Range(0, Iterations).Select(x => (byte)0));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveAt(list.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Int32()
        {
            var list = new List<int>(Enumerable.Range(0, Iterations).Select(x => 0));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveAt(list.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void RemoveLast_Int64()
        {
            var list = new List<long>(Enumerable.Range(0, Iterations).Select(x => 0L));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveAt(list.Count - 1);
            stopwatch.StopAndLog(Iterations);
        }
    }
}
