using System;
class AmarAkbarAnthony
{
    static void Main()
    {
        int a1, a2, a3;
        double h1, h2, h3;

        Console.Write("Amar's age & height: ");
        a1 = Convert.ToInt32(Console.ReadLine());
        h1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Akbar's age & height: ");
        a2 = Convert.ToInt32(Console.ReadLine());
        h2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Anthony's age & height: ");
        a3 = Convert.ToInt32(Console.ReadLine());
        h3 = Convert.ToDouble(Console.ReadLine());

        int youngest = Math.Min(a1, Math.Min(a2, a3));
        double tallest = Math.Max(h1, Math.Max(h2, h3));

        Console.WriteLine("Youngest age = " + youngest);
        Console.WriteLine("Tallest height = " + tallest);
    }
}
