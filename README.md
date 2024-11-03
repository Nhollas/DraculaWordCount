# Dracula Word Count

A C# application that analyses the word length distribution in Bram Stoker's _Dracula_. The program reads the complete text and produces an ordered count of words grouped by length.

## Features

- Fast and memory-efficient word counting using source-generated regex patterns.
- Handles English text with basic word boundaries.
- Outputs results in a clean, tabulated format.

## Setup

1. Ensure you have .NET installed on your machine.
2. Clone this repository.
3. Run the application using `dotnet run`.

## Example Output

```
| Word Length | Count |
|-------------|-------|
| 1           | 42    |
| 2           | 128   |
| 3           | 456   |
...
```

## Implementation Details

The solution uses:

- Source-generated regex patterns for efficient word matching.
- LINQ for grouping and counting words.
- Static methods for better performance.

## Potential Performance Optimisations

1. Parallel Processing

   - Implement parallel text processing for larger files.
   - Split text into chunks and process concurrently.

2. Memory Optimisations

   - Use a streaming approach for very large files.
   - Utilise `Span<T>` for more efficient string operations.

3. Caching

   - Implement result caching for repeated analysis.
   - Cache frequently accessed word patterns.

## Future Feature Requirements

1. Analysis Extensions

   - Most/least common words by length.
   - Statistical analysis (mean word length, standard deviation).

2. Input/Output Enhancements

   - Support for multiple file formats (PDF, EPUB, etc.).
   - Custom output formats (JSON, CSV, XML).

3. Configuration Options

   - Custom regex patterns for different languages.
   - Ignore lists for common words.
   - Case sensitivity options.

4. Integration Possibilities

   - REST API endpoint for remote text analysis.
   - Batch processing capabilities.
   - Command-line interface with various options.

## Testing

The solution is not currently tested, and I would argue the code isn't as testable as it could be.

An example of this is that we should likely start by moving the logic for reading the text content into an interface and inject it using dependency injection (DI) so that when we run our tests, we can stub the interface and set up different scenarios.

At the moment, I think unit tests alone are probably sufficient, but once we introduce an API or something similar, integration tests would be my preferred choice.

```csharp
public interface IFileReader
{
    string ReadAllText(string path);
}
```
