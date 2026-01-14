using System;
using System.Diagnostics;
using System.Text;
class StringVSStringBuilder
{
    static void Main()
    {
        int n = 10000;
        Stopwatch sw = new Stopwatch();

        //string concatenation
        string s = "";

        sw.Start();
        for (int i = 0; i < n; i++)
        {
            s = s + "a";
        }
        sw.Stop();

        Console.WriteLine("String Concatenation Time: " + sw.Elapsed.TotalMilliseconds + " ms");

        // StringBuilder concatenation
        StringBuilder sb = new StringBuilder();

        sw.Restart();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }
        sw.Stop();

        Console.WriteLine("StringBuilder Concatenation Time: " + sw.Elapsed.TotalMilliseconds + " ms");
    }
}
