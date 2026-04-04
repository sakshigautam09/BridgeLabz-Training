using System;
class SplitText
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[,] arr = SplitWords(s);

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine(arr[i, 0] + "\t\t" + arr[i, 1]);
        }
    }
    static string[,] SplitWords(string s)
    {
        string[] words = new string[CountWords(s)];
        int idx = 0;
        string curr = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                curr += s[i];
            }
            else
            {
                if (curr != "")
                {
                    words[idx++] = curr;
                    curr = "";
                }
            }
        }
        if (curr != "")
            words[idx] = curr;
        string[,] arr = new string[words.Length, 2];
        for (int i = 0; i < words.Length; i++)
        {
            arr[i, 0] = words[i];
            arr[i, 1] = GetLength(words[i]).ToString();
        }
        return arr;
    }
    static int CountWords(string s)
    {
        int count = 0;
        bool flag = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ' && !flag)
            {
                count++;
                flag = true;
            }
            else if (s[i] == ' ')
            {
                inWord = false;
            }
        }
        return count;
    }
    static int GetLength(string s)
    {
        int len = 0;
        foreach (char c in s)
        {
            len++;
        }
        return len;
    }
}
