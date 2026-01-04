using System;
class Animal
{
    public string Name;
    public int Age;
    // constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class AnimalHierarchy
{
    static void Main()
    {
        Animal a1 = new Dog("Golden Retriever", 3);
        Animal a2 = new Cat("Whiskers", 2);
        Animal a3 = new Bird("Nightingale", 1);

        a1.MakeSound();
        a2.MakeSound();
        a3.MakeSound();
    }
}
