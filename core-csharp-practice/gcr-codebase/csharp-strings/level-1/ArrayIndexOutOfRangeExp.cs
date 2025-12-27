using System;
class ArrayIndexOutOfRangeExp
{
    static void Main()
    {
        DemonstrateArrayIndexOutOfRangeException();
    }
static void DemonstrateArrayIndexOutOfRangeException()
    {
        try
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine(arr[5]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}