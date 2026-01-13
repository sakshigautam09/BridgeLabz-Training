using System;
class FindSentence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] sentences = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter sentence {i + 1}: ");
            sentences[i] = Console.ReadLine();
        }

        Console.Write("Enter the word to search: ");
        string word = Console.ReadLine();

        int index = -1;
        for (int i = 0; i < n; i++)
        {
            if (sentences[i].Contains(word))
            {
                index = i;
                break;
            }
        }
        if (index != -1)
            Console.WriteLine($"First sentence containing '{word}' is: \"{sentences[index]}\" at index {index}");
        else
            Console.WriteLine($"No sentence contains the word '{word}'.");
    }
}
