using NUnit.Framework;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;

namespace Benchmark.System.IO
{
    [TestFixture]
    public class MemoryMappedFilesTests
    {
        const int Iterations = 10000;

        [TestCase(1)]
        [TestCase(1024)]
        [TestCase(1024 * 1024)]
        public void NonPersistentMemoryMappedFile_CreationDestruction_WithSize(int size)
        {
            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < Iterations; i++)
            {
                using (MemoryMappedFile.CreateNew("testmap", size))
                {
                }
            }
            stopwatch.StopAndLog(Iterations);
        }
    }
}
