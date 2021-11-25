using TestsGeneratorLibrary;

namespace TestsGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = TestsGenerator.CreateGenerator(builder =>
            {
                builder.MaxReadFiles = 10;
                builder.MaxGenerateTests = 10;
                builder.MaxWriteFiles = 10;
            });
            generator.GenerateTestsAsync(@"E:\labs2021\mpp\lab4\TestGenerator\TestsGeneratorApp\input",
                @"E:\labs2021\mpp\lab4\TestGenerator\TestsGeneratorApp\output").Wait();
        }
    }
}