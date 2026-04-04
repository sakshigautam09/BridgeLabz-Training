using System;
class OTP_Generator
{
    static int GenerateOTP()
    {
        Random r = new Random();
        return r.Next(100000, 1000000);
    }

    static bool IsUnique(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] == arr[j]) {
                    return false;
                }
        return true;
    }

    static void Main()
    {
        int[] otps = new int[10];
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
        }
        Console.WriteLine("All Unique: " + IsUnique(otps));
    }
}
