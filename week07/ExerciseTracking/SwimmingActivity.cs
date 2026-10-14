public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() =>
        _laps * 50 / 1000.0 * 0.62;   // miles

    public override double GetSpeed() =>
        (GetDistance() / GetLengthInMinutes()) * 60;

    public override double GetPace() =>
        GetLengthInMinutes() / GetDistance();
}