using System;

public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public string GetDate() => _date;
    public int GetLengthInMinutes() => _lengthInMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string name = GetType().Name.Replace("Activity", "");
        return $"{_date} {name} ({_lengthInMinutes} min) - " +
               $"Distance {GetDistance():F1} miles, " +
               $"Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}