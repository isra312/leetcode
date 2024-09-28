using BenchmarkDotNet.Attributes;
using Questions.Questions;

namespace Benchmark.Benchmarks;

public class ValidParenthesisBenchmark
{
    //private const string input = "{[([{([[[({[([[{{({})}}]])]})]]])}])]}";
    private const string input = "{}{";
    //private const string input = "{{[([{([[[({[([[{{({})}}]])]})]]])}])]}[([{([[[({[([[{{({{[([{([[[({[([[{{({{[([{([[[({[([[{{({{[([{([[[({[([[{{({})}}]])]})]]])}])]}})}}]])]})]]])}])]}})}}]])]})]]])}])]}{[([{([[[({[([[{{({})}}]])]})]]])}])]}})}}]])]})]]])}])]{[([{([[[({[([[{{({})}}]])]})]]])}])]}}";
    //private const string input = "{}";


    [Benchmark]
    public void ExecuteSimpleLoop()
    {
        ValidParenthesis.IsValidSimpleLoop(input);
    }

    [Benchmark]
    public void ExecuteNestedIfs()
    {
        ValidParenthesis.IsValidNestedIfs(input);
    }

    [Benchmark]
    public void ExecuteDictionary()
    {
        ValidParenthesis.IsValidDictionary(input);
    }
}
