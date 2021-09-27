using BenchmarkDotNet.Running;
using TestesBenchmark.Tests;

namespace TestesBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            new BenchmarkSwitcher(new [] { typeof(NewtonsoftVsSystemTextJson) }).Run(args);
        }
    }
}