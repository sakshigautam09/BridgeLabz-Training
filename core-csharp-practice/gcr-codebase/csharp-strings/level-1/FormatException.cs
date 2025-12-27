using System;
class FormatException
{
    static void Main()
    {
        DemonstrateFormatException();
    }
    static void DemonstrateFormatException()
    {
        try
        {
            string s = "abc123";
            int num = int.Parse(s);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}