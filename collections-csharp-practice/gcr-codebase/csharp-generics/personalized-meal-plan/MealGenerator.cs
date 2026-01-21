using System;

public static class MealGenerator
{
    public static Meal<T> GenerateMeal<T>(T mealPlan) where T : IMealPlan
    {
        return new Meal<T>(mealPlan);
    }
}
