using System;

public class Meal<T> where T : IMealPlan
{
    public T MealPlan { get; }

    public Meal(T mealPlan)
    {
        MealPlan = mealPlan;
    }

    public void Display()
    {
        Console.WriteLine(
            $"Meal Type: {MealPlan.MealType}, Calories: {MealPlan.Calories}"
        );
    }
}
