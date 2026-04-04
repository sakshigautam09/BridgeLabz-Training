using System;
using System.Collections.Generic;
public class FrequencyOfElements
{
    static void Main()
    {
        List<string> list = new List<string>();
        Dictionary<string, int> freqMap = new Dictionary<string, int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(Console.ReadLine());
        }

        for (int i = 0; i < list.Count; i++)
        {
            string key = list[i];

            if (freqMap.ContainsKey(key))
            {
                freqMap[key] = freqMap[key] + 1;
            }
            else
            {
                freqMap.Add(key, 1);
            }
        }

        Console.WriteLine("Frequency of elements:");
        foreach (KeyValuePair<string, int> pair in freqMap)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }
}
