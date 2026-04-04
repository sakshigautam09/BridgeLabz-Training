using System;

class LexicalTwist
{
    static void Main()
    {
        Console.WriteLine("Enter the first word");
        string firstWord = Console.ReadLine();

        if (IsInvalidWord(firstWord))
        {
            Console.WriteLine(firstWord + " is an invalid word");
            return;
        }

        Console.WriteLine("Enter the second word");
        string secondWord = Console.ReadLine();

        if (IsInvalidWord(secondWord))
        {
            Console.WriteLine(secondWord + " is an invalid word");
            return;
        }

        if (IsReverse(firstWord, secondWord))
        {
            string reversed = ReverseString(firstWord).ToLower();
            string result = ReplaceVowels(reversed);
            Console.WriteLine(result);
        }
        else
        {
            string combined = (firstWord + secondWord).ToUpper();
            ProcessCombinedWord(combined);
        }
    }

    static bool IsInvalidWord(string word)
    {
        return word.Trim().Contains(" ");
    }

    static bool IsReverse(string first, string second)
    {
        string reversedFirst = ReverseString(first);
        return reversedFirst.Equals(second, StringComparison.OrdinalIgnoreCase);
    }

    static string ReverseString(string word)
    {
        char[] chars = word.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    static string ReplaceVowels(string word)
    {
        char[] chars = word.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (IsVowel(chars[i]))
            {
                chars[i] = '@';
            }
        }

        return new string(chars);
    }

    static void ProcessCombinedWord(string word)
    {
        int vowelCount = 0;
        int consonantCount = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (IsVowel(word[i]))
                vowelCount++;
            else if (char.IsLetter(word[i]))
                consonantCount++;
        }

        if (vowelCount > consonantCount)
        {
            PrintFirstTwoUnique(word, true);
        }
        else if (consonantCount > vowelCount)
        {
            PrintFirstTwoUnique(word, false);
        }
        else
        {
            Console.WriteLine("Vowels and consonants are equal");
        }
    }

    static void PrintFirstTwoUnique(string word, bool wantVowels)
    {
        string result = "";

        for (int i = 0; i < word.Length && result.Length < 2; i++)
        {
            char c = word[i];

            if (wantVowels && IsVowel(c) && !result.Contains(c.ToString()))
            {
                result += c;
            }
            else if (!wantVowels && !IsVowel(c) && char.IsLetter(c) && !result.Contains(c.ToString()))
            {
                result += c;
            }
        }

        Console.WriteLine(result);
    }

    static bool IsVowel(char c)
    {
        return "AEIOUaeiou".IndexOf(c) != -1;
    }
}
