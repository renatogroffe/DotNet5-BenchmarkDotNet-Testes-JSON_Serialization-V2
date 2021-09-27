using BenchmarkDotNet.Running;
using TestesBenchmark.Tests;

namespace TestesBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}