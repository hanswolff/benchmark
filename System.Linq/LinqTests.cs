using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Benchmark.System.Collections
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class LinqTests
    {
        const int singleCount = 2000000;
        const int iterations = 2000000;

        [Test]
        public void Any()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                Enumerable.Range(0, singleCount).Any();
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Single_ToArray()
        {
            var stopwatch = Stopwatch.StartNew();
            Enumerable.Range(0, singleCount).Select(x => 0L).ToArray();
            stopwatch.StopAndLog(singleCount);
        }

        [Test]
        public void Single_ToList()
        {
            var stopwatch = Stopwatch.StartNew();
            Enumerable.Range(0, singleCount).Select(x => 0L).ToList();
            stopwatch.StopAndLog(singleCount);
        }

        [Test]
        public void Multiple_ToArray()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                Enumerable.Range(0, 1).Select(x => 0L).ToArray();
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Multiple_ToList()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                Enumerable.Range(0, 1).Select(x => 0L).ToList();
            }
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
