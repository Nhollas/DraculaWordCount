using DraculaWordCount;

string text = File.ReadAllText("dracula-book.txt");
var results = WordCounter.CountWordsByLength(text);
WordCounter.PrintResults(results);