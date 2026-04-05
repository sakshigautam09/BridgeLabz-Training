using System;
class Person
{
    public string name;
    public int age;

    // Normal Constructor
    public Person(string n, int a)
    {
        name = n;
        age = a;
    }

    // Copy Constructor
    public Person(Person p)
    {
        name = p.name;
        age = p.age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

class PersonClass
    { 
        static void Main()
        {
            Person p1 = new Person("Amit", 25);
            Console.WriteLine("Original Person:");
            p1.Display();

            Console.WriteLine();

            Person p2 = new Person(p1);   // Copy constructor
            Console.WriteLine("Copied Person:");
            p2.Display();
        }
    }
}
