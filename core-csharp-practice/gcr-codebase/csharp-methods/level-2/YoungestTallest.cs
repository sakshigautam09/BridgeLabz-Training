using System;
class YoungestTallest
{
    static int FindYoungest(int[] arr)
    {
        int min = arr[0];
        int idx = 0;
        for (int i = 1; i < 3; i++)
            if (arr[i] < min) { 
                min = arr[i]; 
                idx = i; 
            }
        return idx;
    }

    static int FindTallest(double[] hts)
    {
        double max = hts[0]; 
        int idx = 0;
        for (int i = 1; i < 3; i++)
            if (hts[i] > max) { 
                max = hts[i]; 
                idx = i; 
            }
        return idx;
    }

    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] arr = new int[3];
        double[] hts = new double[3];

        for (int i = 0; i < 3; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            hts[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Youngest: " + names[FindYoungest(arr)]);
        Console.WriteLine("Tallest: " + names[FindTallest(hts)]);
    }
}
