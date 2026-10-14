public class RunningActivity : Activity
{
    private double _distance; // miles

    public RunningActivity(string date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() =>
        (_distance / GetLengthInMinutes()) * 60;

    public override double GetPace() =>
        GetLengthInMinutes() / _distance;
}