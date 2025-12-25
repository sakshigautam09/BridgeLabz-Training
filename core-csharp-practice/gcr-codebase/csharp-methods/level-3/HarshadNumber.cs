using System;
class HarshadNumber
{
    static int CountDigits(int num)
    {
        int count = 0;
        while (num > 0) { 
            count++; num /= 10; 
        }
        return count;
    }

    static int[] StoreDigits(int num)
    {
        int count = CountDigits(num);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        return digits;
    }

    static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits) sum += d;
        return sum;
    }

    static double SumOfSquares(int[] digits)
    {
        double sum = 0;
        foreach (int d in digits) sum += Math.Pow(d, 2);
        return sum;
    }

    static bool IsHarshad(int num, int sumDigits)
    {
        return num % sumDigits == 0;
    }

    static int[,] DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++) freq[i, 0] = i;

        foreach (int d in digits) freq[d, 1]++;
        return freq;
    }

    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] digits = StoreDigits(num);

        Console.WriteLine("Sum of digits: " + SumOfDigits(digits));
        Console.WriteLine("Sum of squares: " + SumOfSquares(digits));
        Console.WriteLine("Harshad: " + IsHarshad(num, SumOfDigits(digits)));

        int[,] freq = DigitFrequency(digits);
        for (int i = 0; i < 10; i++){
            if (freq[i, 1] > 0){
                Console.Write(freq[i, 0]);
                Console.Write(freq[i, 1]);
            }
        }
    }
}
