using System;
class SpringSeason
{
    static bool IsSpring(int month, int day)
    {
        if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
            return true;
        return false;
    }
    static void Main(string[] args)
    {
        int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);
        Console.WriteLine(IsSpring(month, day) ? "Spring Season" : "Not a Spring Season");
    }
}
