public class VeganMeal : IMealPlan
{
    private string mealType = "Vegan";   // field (encapsulated)

    public string MealType               // property (interface contract)
    {
        get { return mealType; }
    }

    public int Calories { get; }

    public VeganMeal(int calories)
    {
        Calories = calories;
    }
}

