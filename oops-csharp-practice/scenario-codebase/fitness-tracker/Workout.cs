public abstract class Workout : ITrackable
{
    private int duration;

    protected Workout(int duration)
    {
        this.duration = duration;
    }

    public int Duration
    {
        get { return duration; }
        protected set { duration = value; }
    }
    public abstract int CalculateCalories();
    public virtual void Track()
    {
        Console.WriteLine($"Duration: {Duration} minutes");
    }
}
