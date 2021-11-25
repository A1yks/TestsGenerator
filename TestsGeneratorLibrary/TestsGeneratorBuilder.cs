using System;

namespace TestsGeneratorLibrary
{
    public class TestsGeneratorBuilder
    {
        private int maxReadFiles = 5;

        private int maxGenerateTests = 5;

        private int maxWriteFiles = 5;

        public int MaxReadFiles
        {
            set => maxReadFiles = value;
        }

        public int MaxGenerateTests
        {
            set => maxGenerateTests = value;
        }

        public int MaxWriteFiles
        {
            set => maxWriteFiles = value;
        }

        public TestsGenerator Build()
        {
            return new TestsGenerator(maxReadFiles, maxGenerateTests, maxWriteFiles);
        }
    }
}