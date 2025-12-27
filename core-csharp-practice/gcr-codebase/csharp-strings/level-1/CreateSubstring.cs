using System;
class CreateSubstring
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        int s_idx = Convert.ToInt32(Console.ReadLine());
        int e_idx = Convert.ToInt32(Console.ReadLine());

        string substr = s.Substring(s_idx, e_idx - s_idx + 1);

        Console.WriteLine(SubstringMethod(s, s_idx, e_idx));
        Console.WriteLine(substr);
    }
    static string SubstringMethod(string s, int s_idx, int e_idx)
    {
        string ans = "";
        for(int i = s_idx; i < e_idx; i++)
        {
            ans += s[i];
        }
        return ans;
    }
}