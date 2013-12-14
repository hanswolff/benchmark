using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Benchmark.System
{
    class StringTests : BenchmarkFixture
    {
        const int IterationsShort = 10000000;
        const int IterationsLong = 1000000;

        [Test]
        public void IsNullOrEmpty_Null()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsShort; i++)
            {
                String.IsNullOrEmpty(null);
            }
            stopwatch.StopAndLog(IterationsShort);
        }

        [Test]
        public void IsNullOrEmpty_Empty()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsShort; i++)
            {
                String.IsNullOrEmpty("");
            }
            stopwatch.StopAndLog(IterationsShort);
        }

        [Test]
        public void IsNullOrEmpty_String()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsShort; i++)
            {
                String.IsNullOrEmpty("test");
            }
            stopwatch.StopAndLog(IterationsShort);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("test")]
        public void Equals_Null(string str)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsShort; i++)
            {
                var b = (str == null);
            }
            stopwatch.StopAndLog(IterationsShort);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("test")]
        public void Equals_Empty(string str)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsShort; i++)
            {
                var b = (str == "");
            }
            stopwatch.StopAndLog(IterationsShort);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("test")]
        public void Equals_String(string str)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsShort; i++)
            {
                var b = (str == "test");
            }
            stopwatch.StopAndLog(IterationsShort);
        }

        [TestCase(0)]
        [TestCase(Math.PI)]
        public void ToString_Decimal(decimal num)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsLong; i++)
            {
                var str = num.ToString();
            }
            stopwatch.StopAndLog(IterationsLong);
        }

        [TestCase(0)]
        [TestCase(Math.PI)]
        public void ToString_Decimal_InvariantCulture(decimal num)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsLong; i++)
            {
                var str = num.ToString(CultureInfo.InvariantCulture);
            }
            stopwatch.StopAndLog(IterationsLong);
        }

        [TestCase(0)]
        [TestCase(Math.PI)]
        public void ToString_Double(double num)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsLong; i++)
            {
                var str = num.ToString();
            }
            stopwatch.StopAndLog(IterationsLong);
        }

        [TestCase(0)]
        [TestCase(Math.PI)]
        public void ToString_Double_InvariantCulture(double num)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < IterationsLong; i++)
            {
                var str = num.ToString(CultureInfo.InvariantCulture);
            }
            stopwatch.StopAndLog(IterationsLong);
        }
    }
}
