using System;
class BasicCalculator{
static void Main()
    {
        double number1, number2;

        Console.Write("Enter first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        double add = number1 + number2;
        double sub = number1 - number2;
        double mul = number1 * number2;
        double div = number1 / number2;

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + number1 + " and " + number2 + " is " + add + ", " + sub + ", " + mul + ", and " + div);
    }
}