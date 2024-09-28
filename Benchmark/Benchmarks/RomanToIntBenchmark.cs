using BenchmarkDotNet.Attributes;
using Questions.Questions;
namespace Benchmark.Benchmarks;

public class RomanToIntBenchmark
{
    [Benchmark]
    public void ExecuteWithReplace()
    {
        RomanToInteger.RomanToIntWithReplace("MMMCMXCIX");
    }

    [Benchmark]
    public void ExecuteWithoutReplace()
    {
        RomanToInteger.RomanToInt("MMMCMXCIX");
    }
}
