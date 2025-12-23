using System;
class FactorOfNumber
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int maxFactor = 10;
        int[] arr = new int[maxFactor];
        int idx = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (idx == maxFactor)
                {
                    // Double array size
                    int[] temp = new int[maxFactor * 2];
                    for (int j = 0; j < maxFactor; j++)
                        temp[j] = arr[j];
                    arr = temp;
                    maxFactor *= 2;
                }
                arr[idx++] = i;
            }
        }

        for (int i = 0; i < idx; i++)
            Console.Write(arr[i] + " ");
    }
}
