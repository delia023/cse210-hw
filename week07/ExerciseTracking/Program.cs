using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity("03 Nov 2022", 30, 3.0));
        activities.Add(new CyclingActivity("03 Nov 2022", 30, 9.7));
        activities.Add(new SwimmingActivity("03 Nov 2022", 30, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}