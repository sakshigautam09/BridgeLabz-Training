using System;
class Program
{
    static void Main()
    {
        try
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            // int[] numbers = null;   // Uncomment this line to test NullReferenceException

            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Value at index " + index + ": " + numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
