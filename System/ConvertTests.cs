using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Benchmark.System
{
    [TestFixture]
    public class ConvertTests
    {
        const int Iterations = 1000000;

        [Test]
        public void Double_ConvertToDouble_StringZero()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var num = Convert.ToDouble("0");
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Double_ConvertToDouble_StringPi()
        {
            var str = Math.PI.ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var num = Convert.ToDouble(str);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Double_DoubleParse_StringPi()
        {
            var str = Math.PI.ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var num = Double.Parse(str);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Decimal_DecimalToDouble_StringZero()
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var num = Convert.ToDecimal("0");
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Decimal_DecimalToDouble_StringPi()
        {
            var str = Math.PI.ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var num = Convert.ToDecimal(str);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void Decimal_DecimalParse_StringPi()
        {
            var str = Math.PI.ToString();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var num = Decimal.Parse(str);
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void StripDecimalPlaces_StringPi()
        {
            const decimal num = (decimal) Math.PI;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var str = num.ToString(CultureInfo.InvariantCulture).Replace(".", "");
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
