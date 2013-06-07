using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;

namespace Benchmark.System
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class ExpandoObjectTests
    {
        const int iterations = 1000000;

        [Test]
        public void SetProperty_ExpandoString_Blank()
        {
            dynamic expandoObject = new ExpandoObject();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                expandoObject.StringProperty = "";
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void GetProperty_ExpandoString_Blank()
        {
            dynamic expandoObject = new ExpandoObject();
            expandoObject.StringProperty = "";

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var prop = expandoObject.StringProperty;
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void SetProperty_ClassString_Blank()
        {
            var obj = new PropertyClass();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                obj.StringProperty = "";
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void GetProperty_ClassString_Blank()
        {
            var obj = new PropertyClass();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var prop = obj.StringProperty;
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void SetProperty_DictionaryString_Blank()
        {
            var obj = new Dictionary<string, object>();
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                obj["StringProperty"] = "";
            }
            stopwatch.StopAndLog(iterations);
        }

        [Test]
        public void GetProperty_DictionaryString_Blank()
        {
            var obj = new Dictionary<string, object>();
            obj["StringProperty"] = "";
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                var prop = obj["StringProperty"];
            }
            stopwatch.StopAndLog(iterations);
        }

        private class PropertyClass
        {
            public string StringProperty { get; set; }
        }
    }
    // ReSharper restore InconsistentNaming
}
