using NUnit.Framework;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Linq
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class ParallelTests
    {
        const int iterations = 2000000;

        [Test]
        public void List_AsParallel_AsOrdered()
        {
            var list = Enumerable.Range(0, iterations).Select(x =>x  % 10).ToList();
            var query = list.AsParallel().AsOrdered().Where(x => x == 0);

            var stopwatch = Stopwatch.StartNew();
            query.ToList();
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void List_Sequential()
        {
            var list = Enumerable.Range(0, iterations).Select(x => x % 10).ToList();
            var query = list.Where(x => x == 0);

            var stopwatch = Stopwatch.StartNew();
            query.ToList();
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
