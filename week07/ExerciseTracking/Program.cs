using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // Instance of RunningActivity Class
        RunningActivity running1 = new RunningActivity("Running","24 Feb 2025",30, 4.8); // Distance

        // Instance of CyclingActivity Class
        CyclingActivity cycling1 = new CyclingActivity("Cycling", "15 Feb 2025", 30, 9.7); // Speed

        // Instance of the SwimmingActivity Class 
        SwimmingActivity swimming1 = new SwimmingActivity("Swimming", "22 Feb 2025", 15, 10); // number of laps

        Console.Clear();

        Console.WriteLine(running1.GetSummary());
        Console.WriteLine(cycling1.GetSummary());
        Console.WriteLine(swimming1.GetSummary());
    }
}