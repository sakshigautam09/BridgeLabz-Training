using System;
class NullRefException
{
    static void Main()
    {
        DemonstrateNullReferenceException();
    }
    static void DemonstrateNullReferenceException()
    {
        try
        {
            string s = null;
            Console.WriteLine(s.Length);
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}