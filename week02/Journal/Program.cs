using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        // Make an instance of the Promptgenerator class
        PromptGenerator myprompts = new PromptGenerator();
        myprompts._prompts.Add("Who was the most interesting person I interacted with today?");
        myprompts._prompts.Add("What was the best part of my day?");
        myprompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        myprompts._prompts.Add("What was the strongest emotion I felt today?");
        myprompts._prompts.Add("If I had one thing I could do over today, what would it be?");


        int choice = 0;


        do 
        {
            // Display menu and ask user for option
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = myprompts.GetRandomPrompt();
                Console.WriteLine(prompt);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Your choice is 2");
            }
            // else if (choice == 3)
            // {

            // }
            // else if (choice == 4)
            // {

            // }


        } while (choice != 5);
    }
}