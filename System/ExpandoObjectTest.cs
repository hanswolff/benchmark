using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;

namespace Benchmark.System
{
    class ExpandoObjectTests : BenchmarkFixture
    {
        const int Iterations = 1000000;

        [Test]
        public void SetProperty_ExpandoString_Blank()
        {
            dynamic expandoObject = new ExpandoObject();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                expandoObject.StringProperty = "";
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void GetProperty_ExpandoString_Blank()
        {
            dynamic expandoObject = new ExpandoObject();
            expandoObject.StringProperty = "";

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var prop = expandoObject.StringProperty;
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void SetProperty_ClassString_Blank()
        {
            var obj = new PropertyClass();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                obj.StringProperty = "";
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void GetProperty_ClassString_Blank()
        {
            var obj = new PropertyClass();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var prop = obj.StringProperty;
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void SetProperty_DictionaryString_Blank()
        {
            var obj = new Dictionary<string, object>();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                obj["StringProperty"] = "";
            }
            stopwatch.StopAndLog(Iterations);
        }

        [Test]
        public void GetProperty_DictionaryString_Blank()
        {
            var obj = new Dictionary<string, object>();
            obj["StringProperty"] = "";
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                var prop = obj["StringProperty"];
            }
            stopwatch.StopAndLog(Iterations);
        }

        private class PropertyClass
        {
            public string StringProperty { get; set; }
        }
    }
}
