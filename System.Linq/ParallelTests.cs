using NUnit.Framework;
using System.Diagnostics;
using System.Linq;

namespace Benchmark.System.Linq
{
    [TestFixture]
    public class ParallelTests
    {
        const int Iterations = 2000000;

        [Test]
        public void List_AsParallel_AsOrdered()
        {
            var list = Enumerable.Range(0, Iterations).Select(x =>x  % 10).ToList();
            var query = list.AsParallel().AsOrdered().Where(x => x == 0);

            var stopwatch = Stopwatch.StartNew();
            query.ToList();
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void List_Sequential()
        {
            var list = Enumerable.Range(0, Iterations).Select(x => x % 10).ToList();
            var query = list.Where(x => x == 0);

            var stopwatch = Stopwatch.StartNew();
            query.ToList();
            stopwatch.StopAndLog(Iterations);
        }
    }
}
