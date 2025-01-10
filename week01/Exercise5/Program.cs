using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // Displays a message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Asks for and returns the user's favorite number  (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        // Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            int numSquared = number * number;
            return numSquared;
        }

        // Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int squarenumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squarenumber}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNum = SquareNumber(userNumber);
        
        DisplayResult(name,squareNum);
    }
}