public class CyclingActivity : Activity
{
    private double _speed; // mph

    public CyclingActivity(string date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance() =>
        _speed * (GetLengthInMinutes() / 60.0);

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}