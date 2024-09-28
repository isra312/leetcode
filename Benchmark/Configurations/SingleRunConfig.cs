using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;

namespace Benchmark.Configurations;

public class SingleRunConfig : ManualConfig
{
    public SingleRunConfig()
    {
        // Run each benchmark method once
        AddJob(Job.Dry.WithInvocationCount(1).WithIterationCount(1).WithUnrollFactor(1));

        // Optional: To make sure benchmarks do not run concurrently, you can use SingleRunStrategy
        AddJob(Job.Dry.WithStrategy(RunStrategy.ColdStart));

        // Add loggers for detailed output
        AddLogger(ConsoleLogger.Default); // Logs to console
        AddLogger(new StreamLogger(new StreamWriter("benchmark.log"))); // Logs to a file

        // Add exporters for different output formats
        AddExporter(HtmlExporter.Default); // Export results as HTML
        AddExporter(MarkdownExporter.GitHub); // Export results as Markdown
        AddExporter(CsvExporter.Default); // Export results as CSV

        // Add default column providers
        AddColumnProvider(DefaultColumnProviders.Instance);
    }
}
