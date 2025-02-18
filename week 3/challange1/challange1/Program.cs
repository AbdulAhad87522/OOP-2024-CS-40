using System;

class ClockType
{
    private int hours;
    private int minutes;
    private int seconds;

    // Constructor to initialize time
    public ClockType(int h = 0, int m = 0, int s = 0)
    {
        SetTime(h, m, s);
    }

    // Method to set the time
    public void SetTime(int h, int m, int s)
    {
        hours = (h >= 0 && h < 24) ? h : 0;
        minutes = (m >= 0 && m < 60) ? m : 0;
        seconds = (s >= 0 && s < 60) ? s : 0;
    }

    // Method to return elapsed time in seconds
    public int ElapsedTime()
    {
        return (hours * 3600) + (minutes * 60) + seconds;
    }

    // Method to return remaining time in seconds
    public int RemainingTime()
    {
        return (24 * 3600) - ElapsedTime();
    }

    // Method to calculate time difference between two clocks
    public int TimeDifference(ClockType otherClock)
    {
        return Math.Abs(this.ElapsedTime() - otherClock.ElapsedTime());
    }

    // Method to display time in hh:mm:ss format
    public void PrintTime()
    {
        Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}

// Main program
class Program
{
    static void Main()
    {
        ClockType clock1 = new ClockType(10, 30, 45);
        ClockType clock2 = new ClockType(15, 45, 30);

        Console.WriteLine("Clock 1 Time:");
        clock1.PrintTime();
        Console.WriteLine($"Elapsed Time: {clock1.ElapsedTime()} seconds");
        Console.WriteLine($"Remaining Time: {clock1.RemainingTime()} seconds\n");

        Console.WriteLine("Clock 2 Time:");
        clock2.PrintTime();
        Console.WriteLine($"Elapsed Time: {clock2.ElapsedTime()} seconds");
        Console.WriteLine($"Remaining Time: {clock2.RemainingTime()} seconds\n");

        Console.WriteLine($"Time Difference Between Clocks: {clock1.TimeDifference(clock2)} seconds");

        Console.ReadKey(); // Wait for key press
    }
}
