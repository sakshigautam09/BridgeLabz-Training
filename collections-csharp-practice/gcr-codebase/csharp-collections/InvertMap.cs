using System;
using System.Collections.Generic;

public class InvertMap
{
    static void Main()
    {
        Dictionary<string, int> map = new Dictionary<string, int>();

        Console.Write("Enter number of entries in the map: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter key {i + 1}: ");
            string key = Console.ReadLine();

            Console.Write($"Enter value {i + 1}: ");
            int value = int.Parse(Console.ReadLine());

            map[key] = value;
        }

        Dictionary<int, List<string>> inverted = InvertDictionary(map);

        Console.WriteLine("\nInverted Map:");
        foreach (KeyValuePair<int, List<string>> pair in inverted)
        {
            Console.Write(pair.Key + " = [");
            Console.Write(string.Join(", ", pair.Value));
            Console.WriteLine("]");
        }
    }

    static Dictionary<int, List<string>> InvertDictionary(Dictionary<string, int> original)
    {
        Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

        foreach (KeyValuePair<string, int> pair in original)
        {
            string key = pair.Key;
            int value = pair.Value;

            if (!inverted.ContainsKey(value))
            {
                inverted[value] = new List<string>();
            }

            inverted[value].Add(key);
        }
        return inverted;
    }
}
