using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string text = File.ReadAllText("Joanne-Rowling - HP - 6. Hari Potyr i Nechistokryvnija prints - 1911.txt");

        List<string> words = ExtractWords(text);
        int wordCount = words.Count;
        string shortestWord = FindShortestWord(words);
        string longestWord = FindLongestWord(words);
        double averageWordLength = CalculateAverageWordLength(words);
        Dictionary<string, int> wordFrequency = CalculateWordFrequency(words);

        stopwatch.Stop();

        Console.WriteLine($"Number of words: {wordCount}");
        Console.WriteLine($"Shortest word: {shortestWord}");
        Console.WriteLine($"Longest word: {longestWord}");
        Console.WriteLine($"Average word length: {averageWordLength:F2}");

        Console.WriteLine("Five most common words:");
        DisplayWordFrequency(wordFrequency, 5, true);

        Console.WriteLine("Five least common words:");
        DisplayWordFrequency(wordFrequency, 5, false);

        Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");

        Console.ReadKey(true);
    }

    static List<string> ExtractWords(string text)
    {
        List<string> words = new List<string>();
        string[] tokens = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            //string word = Regex.Replace(token, @"[^А-Аа-я]", "");
            string word = Regex.Replace(token, @"[^\p{IsCyrillic}]+", "");
            if (word.Length >= 3)
            {
                words.Add(word.ToLower());
            }
        }

        return words;
    }

    static string FindShortestWord(List<string> words)
    {
        string shortestWord = null;
        foreach (string word in words)
        {
            if (shortestWord == null || word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }
        }
        return shortestWord;
    }

    static string FindLongestWord(List<string> words)
    {
        string longestWord = null;
        foreach (string word in words)
        {
            if (longestWord == null || word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        return longestWord;
    }

    static double CalculateAverageWordLength(List<string> words)
    {
        int totalLength = 0;
        foreach (string word in words)
        {
            totalLength += word.Length;
        }
        return (double)totalLength / words.Count;
    }

    static Dictionary<string, int> CalculateWordFrequency(List<string> words)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }
        return wordFrequency;
    }

    static void DisplayWordFrequency(Dictionary<string, int> wordFrequency, int count, bool mostCommon)
    {
        List<KeyValuePair<string, int>> sortedWords = new List<KeyValuePair<string, int>>(wordFrequency);

        if (mostCommon)
        {
            sortedWords.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
        }
        else
        {
            sortedWords.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
        }

        int displayedCount = 0;
        foreach (var pair in sortedWords)
        {
            if (displayedCount >= count)
                break;
            Console.WriteLine($"{pair.Key}: {pair.Value} times");
            displayedCount++;
        }
    }
}
