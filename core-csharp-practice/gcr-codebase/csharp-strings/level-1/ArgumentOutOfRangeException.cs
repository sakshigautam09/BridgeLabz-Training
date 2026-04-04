using System;
class ArgumentOutOfRangeException
{
    static void Main()
    {
        DemonstrateArgumentOutOfRangeException();
    }
    static void DemonstrateArgumentOutOfRangeException()
    {
        try
        {
            string s = "Programming";
            Console.WriteLine(str.Substring(20, 5));
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}