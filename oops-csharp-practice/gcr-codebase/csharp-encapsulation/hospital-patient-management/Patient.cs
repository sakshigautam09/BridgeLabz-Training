using System;

abstract class Patient
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    protected Patient(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}
