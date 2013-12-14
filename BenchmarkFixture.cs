using NUnit.Framework;
using System;

namespace Benchmark
{
    [TestFixture]
    abstract class BenchmarkFixture
    {
        [SetUp]
        public void RunBeforeAnyTests()
        {
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
        }

        [TearDown]
        public void RunAfterAnyTests()
        {
        }
    }
}
