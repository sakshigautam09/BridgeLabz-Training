using System;
using System.Text;
class RemoveDuplicates
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            char curr = input[i];

            if (result.ToString().IndexOf(curr) == -1)
            {
                result.Append(curr);
            }
        }
        Console.WriteLine("After removing duplicates: " + result.ToString());
    }
}
