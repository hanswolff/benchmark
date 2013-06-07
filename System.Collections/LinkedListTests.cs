using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Collections
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class LinkedListTests
    {
        const int iterations = 2000000;

        [Test]
        public void AddFirst_Byte()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new LinkedList<byte>();
            for (var i = 0; i < iterations; i++)
            {
                list.AddFirst(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void AddFirst_Int32()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new LinkedList<int>();
            for (var i = 0; i < iterations; i++)
            {
                list.AddFirst(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void AddFirst_Int64()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new LinkedList<long>();
            for (long i = 0; i < iterations; i++)
            {
                list.AddFirst(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void AddLast_Byte()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new LinkedList<byte>();
            for (var i = 0; i < iterations; i++)
            {
                list.AddLast(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void AddLast_Int32()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new LinkedList<int>();
            for (var i = 0; i < iterations; i++)
            {
                list.AddLast(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void AddLast_Int64()
        {
            var stopwatch = Stopwatch.StartNew();
            var list = new LinkedList<long>();
            for (long i = 0; i < iterations; i++)
            {
                list.AddLast(0);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void ForEach_Byte()
        {
            var list = new LinkedList<byte>(Enumerable.Range(0, iterations).Select(x => (byte)0));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void ForEach_Int32()
        {
            var list = new LinkedList<int>(Enumerable.Range(0, iterations).Select(x => 0));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void ForEach_Int64()
        {
            var list = new LinkedList<long>(Enumerable.Range(0, iterations).Select(x => 0L));

            var stopwatch = Stopwatch.StartNew();
            foreach (var item in list)
            {
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void RemoveLast_Byte()
        {
            var list = new LinkedList<byte>(Enumerable.Range(0, iterations).Select(x => (byte)0));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveLast();
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void RemoveLast_Int32()
        {
            var list = new LinkedList<int>(Enumerable.Range(0, iterations).Select(x => 0));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveLast();
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void RemoveLast_Int64()
        {
            var list = new LinkedList<long>(Enumerable.Range(0, iterations).Select(x => 0L));

            var stopwatch = Stopwatch.StartNew();
            while (list.Count > 0) list.RemoveLast();
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
