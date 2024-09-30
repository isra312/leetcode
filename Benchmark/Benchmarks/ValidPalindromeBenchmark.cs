using BenchmarkDotNet.Attributes;
using Questions.Solutions;
namespace Benchmark.Benchmarks;

public class ValidPalindromeBenchmark
{
    [Benchmark]
    public void ExecuteIsPalindromeStringToLower()
    {
        ValidPalindrome.IsPalindromeStringToLower("A man, a plan, a canal: Panama");
    }

    [Benchmark]
    public void ExecuteIsPalindromeCharToLower()
    {
        ValidPalindrome.IsPalindromeCharToLower("A man, a plan, a canal: Panama");
    }
}
