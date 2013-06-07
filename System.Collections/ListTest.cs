using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Benchmark.System.Collections
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class ListTest
    {
        const int iterations = 2000000;

        [Test]
        public void Add_Byte_Without_Preinitialization()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<byte>();
            for (var i = 0; i < iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Add_Byte_Preinitialized()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<byte>(iterations);
            for (var i = 0; i < iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Add_Int32_Without_Preinitialization()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<int>();
            for (var i = 0; i < iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Add_Int32_Preinitialized()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<int>(iterations);
            for (var i = 0; i < iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Add_Int64_Without_Preinitialization()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<long>();
            for (long i = 0; i < iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Add_Int64_Preinitialized()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new List<long>(iterations);
            for (long i = 0; i < iterations; i++)
            {
                list.Add(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void ForEach_Byte()
        {
            var list = new List<byte>(Enumerable.Range(0, iterations).Select(x => (byte)0));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void ForEach_Int32()
        {
            var list = new List<int>(Enumerable.Range(0, iterations).Select(x => 0));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void ForEach_Int64()
        {
            var list = new List<long>(Enumerable.Range(0, iterations).Select(x => 0L));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void RemoveLast_Byte()
        {
            var list = new List<byte>(Enumerable.Range(0, iterations).Select(x => (byte)0));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveAt(list.Count - 1);
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void RemoveLast_Int32()
        {
            var list = new List<int>(Enumerable.Range(0, iterations).Select(x => 0));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveAt(list.Count - 1);
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void RemoveLast_Int64()
        {
            var list = new List<long>(Enumerable.Range(0, iterations).Select(x => 0L));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveAt(list.Count - 1);
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
