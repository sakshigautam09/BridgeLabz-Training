using System;
class ArmstrongNumber
{
    static void Main()
    {
        int n, temp, rem, sum = 0;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        temp = n;
        while (temp != 0)
        {
            rem = temp % 10;  
            sum += rem * rem * rem; 
            temp = temp / 10;
        }

        if (sum == n)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
