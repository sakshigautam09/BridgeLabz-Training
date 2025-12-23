using System;
class OddAndEven
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("not a natural number.");
            return;
        }

        int size = number / 2 + 1;
        int[] odd_arr = new int[size];
        int[] even_arr = new int[size];
        int odd_idx = 0, even_idx = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even_arr[even_idx++] = i;
            else
                odd_arr[odd_idx++] = i;
        }

        for (int i = 0; i < odd_idx; i++)
            Console.Write(odd_arr[i] + " ");

        for (int i = 0; i < even_idx; i++)
            Console.Write(even_arr[i] + " ");
    }
}
