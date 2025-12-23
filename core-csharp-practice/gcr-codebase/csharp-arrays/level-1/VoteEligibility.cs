using System;
class VoteEligibility
{
    public static void Main(String[] args)
    {
        int[] arr = new int[10];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.Read());
        }
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < 0)
            {
                Console.WriteLine("Invalid Age");
            }
            else if(arr[i] >= 18)
            {
                Console.WriteLine($"The student with the age {arr[i]} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with the age {arr[i]} cannot vote.");
            }
        }
    }
}