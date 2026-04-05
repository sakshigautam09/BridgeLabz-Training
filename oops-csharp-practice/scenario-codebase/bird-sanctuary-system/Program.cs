using System;
class Program
{
    static void Main()
    {
        Bird[] birds = new Bird[]
        {
            new Eagle("Mighty Eagle"),
            new Sparrow("Tiny Sparrow"),
            new Duck("Pond Duck"),
            new Penguin("Happy Penguin"),
            new Seagull("Ocean Seagull")
        };

        Console.WriteLine("EcoWing Bird Sanctuary Report");

        foreach (Bird bird in birds)
        {
            bird.DisplayInfo();

            if (bird is IFlyable flyable)
            {
                flyable.Fly();
            }

            if (bird is ISwimmable swimmable)
            {
                swimmable.Swim();
            }
        }
    }
}
