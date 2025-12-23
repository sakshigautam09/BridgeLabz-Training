using System;
class FizzBuzz
{
    public static void Main(string[] args)
    {
        int number = Convert.toInt32(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Number is negative.");
            return;
        }
        string[] arr = new string[number + 1];

        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                arr[i] = "FizzBuzz";
            else if (i % 3 == 0)
                arr[i] = "Fizz";
            else if (i % 5 == 0)
                arr[i] = "Buzz";
            else
                arr[i] = i.ToString();
        }

        for (int i = 0; i <= number; i++)
            Console.WriteLine("Position " + i + " = " + arr[i]);
    }
}
