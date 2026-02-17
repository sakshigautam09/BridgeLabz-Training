// ======================================
// UC-5: Safe Input Handling
// ======================================

using System;

public class SafeInputHandler
{
    public int GetSafeInt(string message)
    {
        while (true)
        {
            try
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number! Try again.");
            }
        }
    }

    public double GetSafeDouble(string message)
    {
        while (true)
        {
            try
            {
                Console.Write(message);
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid decimal input! Try again.");
            }
        }
    }
}
