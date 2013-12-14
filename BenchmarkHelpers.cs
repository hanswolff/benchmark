using NUnit.Framework;
using System.Diagnostics;

namespace Benchmark
{
    public static class BenchmarkHelpers
    {
        public static void StopAndLog(this Stopwatch stopwatch, long iterations)
        {
            stopwatch.Stop();
            var seconds = stopwatch.ElapsedTicks / (decimal)Stopwatch.Frequency;
            Assert.Inconclusive("{0:N2} ms --- {1:N0} operations/sec --- {2} precision timer",
                seconds * 1000m, 
                iterations / (seconds + 0.0000001m),
                Stopwatch.IsHighResolution ? "high" : "low");
        }
    }
}
