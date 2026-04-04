using System;
class FlipKeyLogical
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string ans = CleanseAndInvert(input);

        if(ans == "")
        {
            Console.WriteLine("Invalid string");
        }
        else
        {
            Console.WriteLine("Generated key: " + ans);
        }
        
    }
    public static string CleanseAndInvert(string s)
    {
        if(s == null || s.Length < 6)
        {
            return "";
        }
        for(int i = 0; i < s.Length; i++)
        {
            if (!char.IsLetter(s[i]))
            {
                return "";
            }
        }

        string lowerCaseInput = s.ToLower();
        string filtered = "";

        for(int i=0; i < lowerCaseInput.Length; i++)
        {
            int ascii = (int)lowerCaseInput[i];
            if(ascii % 2 == 0)
            {
                filtered += lowerCaseInput[i];
            }
        }

        char[] arr = filtered.ToCharArray();
        Array.Reverse(arr);

        for(int i = 0; i < arr.Length; i++)
        {
            if(i % 2 == 0)
            {
                arr[i] = char.ToUpper(arr[i]);
            }
        }
        return new string(arr);
    }
}