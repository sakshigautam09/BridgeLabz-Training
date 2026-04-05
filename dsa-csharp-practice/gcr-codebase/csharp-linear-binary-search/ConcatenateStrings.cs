using System;
using System.Text;
class concatenateStrings
{
    static void Main()
    {
        Console.Write("How many strings do you want to concatenate? ");
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter string {i}: ");
            string s = Console.ReadLine();
            sb.Append(s);  // Append each word
        }
        Console.WriteLine("Concatenated String: " + sb.ToString());
    }
}
