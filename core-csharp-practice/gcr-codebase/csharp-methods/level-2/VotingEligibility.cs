using System;
class VotingEligibility
{
    public static bool CanVote(int age)
    {
        if (age < 0) return false;
        return age >= 18;
    }
    static void Main()
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(CanVote(arr[i]) ? "Can Vote" : "Cannot Vote");
        }
    }
}
