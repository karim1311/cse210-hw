using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Generate a random number from 1 to 100
        // In addition, for this assignment you'll need to get a random number from the computer. In C#, this is done by
        // creating an instance of the Random Class, and then using it to get the next integer in a particular range.
        Random randomGenerator =  new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        do 
        {
            // Ask user for guess 
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        } while (guess != magicNumber);

        Console.WriteLine("You guessed it!");
        
    }
}