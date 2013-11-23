﻿using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading;

namespace Benchmark.System.Threading
{
    [TestFixture]
    public class MutexTests
    {
        const int Iterations = 100000;

        [Test]
        public void CreationDestruction()
        {
            var name = Guid.NewGuid().ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                using (new Mutex(true, name))
                {
                }
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
