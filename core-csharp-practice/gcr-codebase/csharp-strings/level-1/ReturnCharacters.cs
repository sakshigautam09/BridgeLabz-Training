using System;
class ReturnCharacters
{
    static void Main()
    {
        string s = Console.ReadLine();

        char[] arr = GetCharacters(s);
        char[] builtIn = s.ToCharArray();

        PrintArr(arr);
        PrintArr(builtIn);
    }
    static char[] GetCharacters(string s)
    {
        char[] ch = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            ch[i] = s[i];
        }
        return ch;
    }

    static void PrintArr(char[] arr)
    {
        foreach (char c in arr)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}
