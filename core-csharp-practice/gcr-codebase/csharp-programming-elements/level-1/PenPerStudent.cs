using System;

class PenPerStudent
{
    static void Main()
    {
        int totalPens = 14;
        int stud = 3;

        int pensPerStudent = totalPens / stud;
        int remainingPens = totalPens % stud;

        Console.WriteLine(
            "The Pen Per Student is " + pensPerStudent + " and the remaining pen not distributed is " + remainingPens);
    }
}
