using System;
class MostFrequentCharacter
{
    static void Main()
    {
        string s = Console.ReadLine();
        int[] freq = new int[256];
        foreach (char c in s)
        {
            freq[c]++;
        }
        int max = 0;
        char ch = '\0';
        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] > max)
            {
                max = freq[i];
                ch = (char)i;
            }
        }
        Console.WriteLine(ch);
    }
}