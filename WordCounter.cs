using System.Text.RegularExpressions;

namespace DraculaWordCount;

public static partial class WordCounter  
{
    private static readonly Regex EnglishWordPattern = MyRegex();

    public static Dictionary<int, int> CountWordsByLength(string text)
    {
        return EnglishWordPattern.Matches(text)
            .GroupBy(m => m.Length)
            .OrderBy(x => x.Key)
            .ToDictionary(
                g => g.Key,
                g => g.Count()
            );
    }

    public static void PrintResults(Dictionary<int, int> wordCounts)
    {
        Console.WriteLine("| Word Length | Count |");
        Console.WriteLine("|-------------|-------|");
            
        foreach (var kvp in wordCounts)
        {
            Console.WriteLine($"| {kvp.Key,-11} | {kvp.Value,-5} |");
        }
    }

    [GeneratedRegex(@"\b[a-zA-Z]+\b", RegexOptions.Compiled)]
    private static partial Regex MyRegex();
}