using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string path = "Joanne-Rowling - HP - 6. Hari Potyr i Nechistokryvnija prints - 1911.txt";
        string text = File.ReadAllText(path);

        List<string> words = ExtractWords(text);

        Thread wordCountThread = new Thread(() =>
        {
            int wordCount = words.Count;
            Console.WriteLine($"Number of words: {wordCount}");
        });

        Thread shortestWordThread = new Thread(() =>
        {
            string shortestWord = FindShortestWord(words);
            Console.WriteLine($"Shortest word: {shortestWord}");
        });

        Thread longestWordThread = new Thread(() =>
        {
            string longestWord = FindLongestWord(words);
            Console.WriteLine($"Longest word: {longestWord}");
        });

        Thread averageWordLengthThread = new Thread(() =>
        {
            double averageWordLength = CalculateAverageWordLength(words);
            Console.WriteLine($"Average word length: {averageWordLength:F2}");
        });

        Thread wordFrequencyThread = new Thread(() =>
        {
            Dictionary<string, int> wordFrequency = CalculateWordFrequency(words);
            Console.WriteLine("Five most common words:");
            DisplayWordFrequency(wordFrequency, 5, true);

            Console.WriteLine("Five least common words:");
            DisplayWordFrequency(wordFrequency, 5, false);
        });

        wordCountThread.Start();
        shortestWordThread.Start();
        longestWordThread.Start();
        averageWordLengthThread.Start();
        wordFrequencyThread.Start();

        wordCountThread.Join();
        shortestWordThread.Join();
        longestWordThread.Join();
        averageWordLengthThread.Join();
        wordFrequencyThread.Join();

        stopwatch.Stop();

        Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}ms");
        Console.ReadKey(true);
    }

    static List<string> ExtractWords(string text)
    {
        List<string> words = new List<string>();
        string[] tokens = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            string word = Regex.Replace(token, @"[^а-яА-Я]", "");
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

