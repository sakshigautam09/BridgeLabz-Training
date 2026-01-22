using System;
using System.IO;
using System.Collections.Generic;

class CountWords
{
    static void Main()
    {
        string filePath = "input.txt";

        Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        try
        {
            StreamReader reader = new StreamReader(filePath);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(
                    new char[] { ' ', '\t', ',', '.', ';', ':', '!', '?', '"', '(', ')', '[', ']' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }

            reader.Close();

            // Convert dictionary to list for sorting
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>(wordCount);

            // Sort manually in descending order of count
            list.Sort((a, b) => b.Value.CompareTo(a.Value));

            // Print top 5
            int top = Math.Min(5, list.Count);
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine($"{list[i].Key} : {list[i].Value}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
