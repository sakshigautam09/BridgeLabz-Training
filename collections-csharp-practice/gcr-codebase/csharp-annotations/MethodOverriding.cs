using System;
using NUnit.Framework;

// --------------------- Parent Class: Animal ---------------------
public class Animal
{
    public virtual string MakeSound()
    {
        return "Animal makes a sound";
    }
}

// --------------------- Child Class: Dog ---------------------
public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Dog barks";
    }
}

// --------------------- NUnit Test Class ---------------------
[TestFixture] // Annotation indicating this is a test class
public class AnimalTests
{
    private Animal animal;
    private Dog dog;

    [SetUp] // Runs before each test
    public void Setup()
    {
        animal = new Animal();
        dog = new Dog();
    }

    [Test] // Marks this as a test method
    public void Animal_MakeSound_ReturnsCorrectString()
    {
        string result = animal.MakeSound();
        Assert.AreEqual("Animal makes a sound", result);
    }

    [Test] // Test overridden method
    public void Dog_MakeSound_ReturnsOverriddenString()
    {
        string result = dog.MakeSound();
        Assert.AreEqual("Dog barks", result);
    }

    [Test] // Test polymorphic behavior
    public void Polymorphic_AnimalReferenceToDog_CallsDogMethod()
    {
        Animal polyDog = new Dog();
        string result = polyDog.MakeSound();
        Assert.AreEqual("Dog barks", result); // Calls overridden method
    }
}
