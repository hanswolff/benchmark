using System;
using System.Diagnostics;
using System.Globalization;
using NUnit.Framework;

namespace Benchmark.System
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class StringTests
    {
        const int iterations = 10000000;
        const int iterations2 = 1000000;

        [Test]
        public void IsNullOrEmpty_Null()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                String.IsNullOrEmpty(null);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void IsNullOrEmpty_Empty()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                String.IsNullOrEmpty("");
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void IsNullOrEmpty_String()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                String.IsNullOrEmpty("test");
            }
            stopwatch.StopAndLog(iterations);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("test")]
        public void Equals_Null(string str)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var b = (str == null);
            }
            stopwatch.StopAndLog(iterations);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("test")]
        public void Equals_Empty(string str)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var b = (str == "");
            }
            stopwatch.StopAndLog(iterations);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("test")]
        public void Equals_String(string str)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var b = (str == "test");
            }
            stopwatch.StopAndLog(iterations);
        }

        [TestCase(0)]
        [TestCase(Math.PI)]
        public void ToString_Decimal(decimal num)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations2; i++)
            {
                var str = num.ToString();
            }
            stopwatch.StopAndLog(iterations2);
        }

        [TestCase(0)]
        [TestCase(Math.PI)]
        public void ToString_Decimal_InvariantCulture(decimal num)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations2; i++)
            {
                var str = num.ToString(CultureInfo.InvariantCulture);
            }
            stopwatch.StopAndLog(iterations2);
        }

        [TestCase(0)]
        [TestCase(Math.PI)]
        public void ToString_Double(double num)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations2; i++)
            {
                var str = num.ToString();
            }
            stopwatch.StopAndLog(iterations2);
        }

        [TestCase(0)]
        [TestCase(Math.PI)]
        public void ToString_Double_InvariantCulture(double num)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations2; i++)
            {
                var str = num.ToString(CultureInfo.InvariantCulture);
            }
            stopwatch.StopAndLog(iterations2);
        }
    }
    // ReSharper restore InconsistentNaming
}
