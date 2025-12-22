using System;
class Program
{
    static void Main()
    {
        int n, temp, sum = 0;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        temp = n;

        while (temp != 0)
        {
            sum += temp % 10; 
            temp = temp / 10;
        }
        if (n % sum == 0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not a Harshad Number");
    }
}
