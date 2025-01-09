using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // ask for firstname with console write, this just prints this text
        Console.Write("Please enter your first name: ");

        // we save the variable here reading our input and saving into a string variable
        string fname = Console.ReadLine();

        // we do the same for last name
        Console.Write("Please enter your last name: ");
        string lname = Console.ReadLine();

        // we print variables inside a string with dollar sign and curly braces
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}