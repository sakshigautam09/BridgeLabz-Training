using System;
class IndexOutOfRangeException
{
    static void Main()
    {
        DemonstrateIndexOutOfRangeException();
    }
static void DemonstrateIndexOutOfRangeException()
    {
        try
        {
            string s = "Hello";
            Console.WriteLine(s[8]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}