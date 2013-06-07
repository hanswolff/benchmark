using System;
using System.Diagnostics;
using System.Globalization;
using NUnit.Framework;

namespace Benchmark.System
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class ConvertTests
    {
        const int iterations = 1000000;

        [Test]
        public void Double_ConvertToDouble_StringZero()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var num = Convert.ToDouble("0");
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Double_ConvertToDouble_StringPi()
        {
            var str = Math.PI.ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var num = Convert.ToDouble(str);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Double_DoubleParse_StringPi()
        {
            var str = Math.PI.ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var num = Double.Parse(str);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Decimal_DecimalToDouble_StringZero()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var num = Convert.ToDecimal("0");
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Decimal_DecimalToDouble_StringPi()
        {
            var str = Math.PI.ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var num = Convert.ToDecimal(str);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void Decimal_DecimalParse_StringPi()
        {
            var str = Math.PI.ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var num = Decimal.Parse(str);
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void StripDecimalPlaces_StringPi()
        {
            const decimal num = (decimal) Math.PI;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var str = num.ToString(CultureInfo.InvariantCulture).Replace(".", "");
            }
            stopwatch.StopAndLog(iterations);
        }
    }
    // ReSharper restore InconsistentNaming
}
