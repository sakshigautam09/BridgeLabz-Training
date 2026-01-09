using System;

class Program
{
    static void Main()
    {
        UserProfile user = new UserProfile("Sakshi");

        Workout workout = new CardioWorkout(30, 140);
        // Workout workout = new StrengthWorkout(45, 80);

        user.AssignWorkout(workout);
        user.ShowWorkoutSummary();
    }
}
