using NUnit.Framework;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Linq
{
    [TestFixture]
    public class LinqTests
    {
        const int SingleCount = 2000000;
        const int Iterations = 2000000;

        [Test]
        public void Any()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                Enumerable.Range(0, SingleCount).Any();
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Single_ToArray()
        {
            var stopwatch = Stopwatch.StartNew();
            Enumerable.Range(0, SingleCount).Select(x => 0L).ToArray();
            stopwatch.StopAndLog(SingleCount);
        }

        [Test]
        public void Single_ToList()
        {
            var stopwatch = Stopwatch.StartNew();
            Enumerable.Range(0, SingleCount).Select(x => 0L).ToList();
            stopwatch.StopAndLog(SingleCount);
        }

        [Test]
        public void Multiple_ToArray()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                Enumerable.Range(0, 1).Select(x => 0L).ToArray();
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Multiple_ToList()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                Enumerable.Range(0, 1).Select(x => 0L).ToList();
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
