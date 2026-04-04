using System;
class PrintTable
{
    public static void Main(String[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[10];
        for(int i = 1; i <= arr.Length; i++)
        {
            arr[i-1] = number * i;
        }
        for(int i = 1; i <= arr.Length; i++)
        {
            Console.WriteLine($"{number} * {i} = {arr[i-1]}");
        }
    }
}