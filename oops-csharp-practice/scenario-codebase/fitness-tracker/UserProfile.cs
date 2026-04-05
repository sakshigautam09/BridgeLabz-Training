public class UserProfile
{
    private string name;
    private Workout workout; // single workout reference

    public UserProfile(string name)
    {
        this.name = name;
    }

    public void AssignWorkout(Workout workout)
    {
        this.workout = workout;
    }

    public void ShowWorkoutSummary()
    {
        Console.WriteLine($"User: {name}");

        if (workout == null)
        {
            Console.WriteLine("No workout assigned.");
            return;
        }

        workout.Track(); // polymorphism
        Console.WriteLine($"Calories Burned: {workout.CalculateCalories()}");
    }
}
