using NUnit.Framework;
using System;
using System.Threading;

namespace Benchmark
{
    [TestFixture]
    abstract class BenchmarkFixture
    {
        // avoid running tests in parallel
        private static readonly object TestLock = new object();

        [SetUp]
        public void RunBeforeAnyTests()
        {
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();

            Monitor.Enter(TestLock);
        }

        [TearDown]
        public void RunAfterAnyTests()
        {
            Monitor.Exit(TestLock);
        }
    }
}
