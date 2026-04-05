public sealed class CardioWorkout : Workout
{
    private int heartRate;

    public CardioWorkout(int duration, int heartRate)
        : base(duration)
    {
        this.heartRate = heartRate;
    }

    public override int CalculateCalories()
    {
        return (Duration * heartRate) / 10;
    }

    public override void Track()
    {
        Console.WriteLine("Workout Type: Cardio");
        base.Track();
    }
}
