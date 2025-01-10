using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // Ask user for grade percentage
        Console.Write("Enter your grade percentage: ");

        // Catch the value with console readline, store in a variable as string 
        string valueFromUser = Console.ReadLine();

        // Convert input to an integer
        int gradePercentage = int.Parse(valueFromUser);
        string lettergrade = "";

        if (gradePercentage >= 90)
        {
            lettergrade = "A";
        }
        else if (gradePercentage >=80)
        {
            lettergrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            lettergrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            lettergrade = "D";
        }
        else 
        {
            lettergrade = "F";
        }

        if (gradePercentage%10 >= 7 && lettergrade != "A" && lettergrade != "F")
        {
            string letter = lettergrade + "+";
            // We determine the letter grade 
            Console.WriteLine($"Your letter grade is {letter}");
        }   
        else if (gradePercentage % 10 < 3 && lettergrade != "F")
        {
            string letter = lettergrade + "-";
            // We determine the letter grade 
            Console.WriteLine($"Your letter grade is {letter}");
        }
        else 
        {
            Console.WriteLine($"Your letter grade is {lettergrade}");
        }

        if (lettergrade == "D" || lettergrade == "F")
        {
            Console.WriteLine("You did not pass the course, you can do better next time!");
        } 
        else 
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }

    }
}