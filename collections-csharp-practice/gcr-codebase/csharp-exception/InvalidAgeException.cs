using System;

// Custom Exception
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            ValidateAge(age);
            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException)
        {
            Console.WriteLine("Age must be 18 or above");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Invalid age");
        }
    }
}
