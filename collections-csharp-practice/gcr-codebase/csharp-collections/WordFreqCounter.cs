using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class WordFreqCounter
{
    static void Main()
    {
        Console.Write("Enter path of the text file: ");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist!");
            return;
        }

        string text = File.ReadAllText(filePath);

        // Convert to lowercase and remove punctuation
        text = text.ToLower();

        string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' });

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        Console.WriteLine("\nWord Frequencies:");
        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
