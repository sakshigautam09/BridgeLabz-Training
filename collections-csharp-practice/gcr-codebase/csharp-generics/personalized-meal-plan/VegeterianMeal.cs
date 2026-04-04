public class VegetarianMeal : IMealPlan
{
    public string MealType { get; } = "Vegetarian";
    public int Calories { get; }

    public VegetarianMeal(int calories)
    {
        Calories = calories;
    }
}
