using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Activity 1
        DateTime date1 = new DateTime(2024, 11, 23);
        int time1 = 30;
        double distance1 = 2.8;

        Running running = new Running(date1, time1, distance1);

        // Activity 2
        DateTime date2 = new DateTime(2024, 08, 08);
        int time2 = 100;
        double speed2 = 16;

        Cycling cycling = new Cycling(date2, time2, speed2);

        // Activity 3
        DateTime date3 = new DateTime(2024, 01, 23);
        int time3 = 10;
        double laps3 = 4;

        Swimming swimming = new Swimming(date3, time3, laps3);

        List<Activity> activities = new List<Activity> {
            running,
            cycling,
            swimming
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}