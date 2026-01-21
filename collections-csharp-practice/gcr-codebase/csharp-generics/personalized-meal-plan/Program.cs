class Program
{
    static void Main()
    {
        var vegMeal = MealGenerator.GenerateMeal(new VegetarianMeal(500));
        var veganMeal = MealGenerator.GenerateMeal(new VeganMeal(450));

        vegMeal.Display();
        veganMeal.Display();
    }
}
