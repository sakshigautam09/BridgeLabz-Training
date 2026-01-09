public sealed class StrengthWorkout : Workout
{
    private int weightLifted;

    public StrengthWorkout(int duration, int weightLifted)
        : base(duration)
    {
        this.weightLifted = weightLifted;
    }

    public override int CalculateCalories()
    {
        return (Duration * weightLifted) / 20;
    }

    public override void Track()
    {
        Console.WriteLine("Workout Type: Strength");
        base.Track();
    }
}
