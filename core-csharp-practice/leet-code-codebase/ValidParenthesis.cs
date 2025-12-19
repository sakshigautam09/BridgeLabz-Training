using System;
using System.Collections.Generic;

public class ValidParenthesis
{
   public bool IsValid(string s)
    {
        bool changed = true;

        while (changed)
        {
            changed = false;

            if (s.Contains("()"))
            {
                s = s.Replace("()", "");
                changed = true;
            }
            else if (s.Contains("{}"))
            {
                s = s.Replace("{}", "");
                changed = true;
            }
            else if (s.Contains("[]"))
            {
                s = s.Replace("[]", "");
                changed = true;
            }
        }

        return s.Length == 0;
    }
}