using System.Diagnostics;
using NUnit.Framework;

namespace Benchmark
{
    public static class BenchmarkHelpers
    {
        public static void StopAndLog(this Stopwatch stopwatch, long iterations)
        {
            stopwatch.Stop();
            Assert.Inconclusive("{0} ms --- {1:N0} operations/sec", stopwatch.ElapsedMilliseconds, 1000 * iterations / (stopwatch.ElapsedMilliseconds + 0.0000001));
        }
    }
}
