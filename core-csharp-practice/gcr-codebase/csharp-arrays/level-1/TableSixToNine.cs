using System;
class TableSixToNine
{
    public static void Main(string[] args)
    {
        int number;
        int[] arr = new int[4];

        number = int.Parse(Console.ReadLine());
        int index = 0;

        for (int i = 6; i <= 9; i++)
        {
            arr[index] = number * i;
            index++;
        }

        index = 0;
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {arr[index]}");
            index++;
        }
    }
}
