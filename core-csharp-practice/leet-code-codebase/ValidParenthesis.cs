using System;
using System.Collections.Generic;

public class ValidParenthesis
{
    public bool isValid(string s)
    {
        int n = s.Length;
        Stack<char> st = new Stack<char>();

        foreach (char ch in s)
        {
            if (st.Count == 0 || ch == '(' || ch == '{' || ch == '[')
            {
                st.Push(ch);
                continue; // skip to next iteration
            }

            if (ch == ')')
            {
                if (st.Peek() == '(')
                    st.Pop();
                else
                    return false;
            }
            else if (ch == '}')
            {
                if (st.Peek() == '{')
                    st.Pop();
                else
                    return false;
            }
            else if (ch == ']')
            {
                if (st.Peek() == '[')
                    st.Pop();
                else
                    return false;
            }
        }

        return st.Count == 0;
    }
}