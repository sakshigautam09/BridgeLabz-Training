using System;
class StoreValuesInArray
{
    public static void Main(string[] args)
    {
        double[] arr = new double[10];   
        double total = 0.0;            
        int index = 0;                   

        while (true)
        {
            double num = double.Parse(Console.ReadLine());

            if (num <= 0)
            {
                break;
            }

            if (index == 10)
            {
                break;
            }

            arr[index] = num;
            index++;
        }

        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(arr[i]);
            total += arr[i];
        }

        Console.WriteLine(total);
    }
}
