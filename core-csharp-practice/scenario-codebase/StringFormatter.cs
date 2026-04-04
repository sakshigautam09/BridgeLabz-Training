using System;
class StringFormatter
{
    static void Main()
    {
        Console.WriteLine("1. String Formatter.");
        Console.WriteLine("2. Analyze Paragraph.");
        Console.Write("Choose an option: ");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1":
                Console.WriteLine("String Formatter");
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();
                Console.WriteLine(FinalFormattedString(input));
                break;
            case "2":
                Console.WriteLine("Analyze Paragraph");
                Console.Write("Enter a paragraph: ");
                string paragraph = Console.ReadLine();
                string wordToReplace = "oldWord";  // Example old word
                string ToReplaceWith = "newWord";       // Example new word
                AnalyzedParagraph(paragraph, wordToReplace, ToReplaceWith);
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    // Function to format the string
    static string FinalFormattedString(String s)
    {
        s = SpaceAfterPunctuation(s);      
        s = Trim(s);                
        s = CapitalizeAfterAllMarks(s);    
        s = RemoveExtraSpaces(s);
        return s;
    }
    static string RemoveExtraSpaces(String s){
        string ans = "";
        bool inSpace = false; 
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                if (!inSpace)
                {
                    ans += s[i];
                    inSpace = true;
                }
            }
            else
            {
                ans += s[i];
                inSpace = false;
            }
        }
        return ans;  
    }
    static string SpaceAfterPunctuation(String s)
    {
        string ans = "";
        for (int i = 0; i < s.Length; i++)
        {
            ans += s[i];
            if ((s[i] == '.' || s[i] == ',' || s[i] == '!' || s[i] == '?') && (i + 1 < s.Length) && s[i + 1] != ' ')
            {
                ans += ' ';
            }
        }
        return ans;
    }
    static string Trim(String s)
    {
        int start = 0;
        int end = s.Length - 1; 
        while (start <= end && s[start] == ' ')
        {
            start++;
        }
        while (start <= end && s[end] == ' ')
        {
            end--;
        }
        string trimmed = "";
        for (int i = start; i <= end; i++)
        {
            trimmed += s[i];
        }
        return trimmed;
    }
    static string CapitalizeAfterAllMarks(string s)
    {
        string ans = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]) && (i == 0 || s[i - 1] == '.' || s[i - 1] == '!' || s[i - 1] == '?' || s[i - 1] == ','))
            {
                ans += char.ToUpper(s[i]);
            }
            else
            {
                ans += s[i];
            }
        }
        return ans;
    }

    // function to analyze paragraph
    static void AnalyzedParagraph(string s, string oldWord, string newWord)
    {
        int wordCount = CountWordsInParagraph(s);
        string longestWord = DisplayLongestWord(s);

        Console.WriteLine("Number of words in paragraph: " + wordCount);
        Console.WriteLine("Longest word in paragraph: " + longestWord);
        Console.WriteLine("Is paragraph empty: " + IsParagraphEmpty(s));
        Console.WriteLine("Replaced paragraph: " + ReplaceWords(s, oldWord, newWord));
    }
    static int CountWordsInParagraph(string s)
    {
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ' && s[i] != '\n' && s[i] != '\t')   // word does not start with space
            {
                if (i == 0 || s[i - 1] == ' ' || s[i - 1] == '\n' || s[i - 1] == '\t')  // to count, either it is the first word or prev char is space (ensures new word)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static string DisplayLongestWord(String s)
    {
        string longestWord = "";
        string curr = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ' && s[i] != '\n' && s[i] != '\t')
            {
                curr += s[i];
            }
            else
            {
                if (curr.Length > longestWord.Length)
                {
                    longestWord = curr;
                }
                curr = "";
            }
        }
        if (curr.Length > longestWord.Length)   //if string does not end with space, the last word gets skipped 
        {
            longestWord = curr;
        }
        return longestWord;
    }
    static bool IsParagraphEmpty(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
                return false;
        }
        return true;
    }
    static string ReplaceWords(string s, string oldWord, string newWord)
    {
        string result = "";
        int i = 0;

        while (i < s.Length)
        {
            bool match = true;

            if (i + oldWord.Length <= s.Length)
            {
                for (int j = 0; j < oldWord.Length; j++)
                {
                    char c1 = s[i + j];
                    char c2 = oldWord[j];

                    // instead of builtIn
                    if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32); 
                    if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);

                    if (c1 != c2)
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    result += newWord;
                    i += oldWord.Length;
                    continue;
                }
            }
            result += s[i];
            i++;
        }
        return result;
    }
}