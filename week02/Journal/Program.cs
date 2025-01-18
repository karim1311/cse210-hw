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

        // Instance of the Journal Class
        Journal myJournal = new Journal();

        // Instance of DateTime class
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        // add prompts to the _prompts list
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
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            // write
            if (choice == 1)
            {
                // Instance of the Entry class
                Entry myEntry = new Entry();

                // Save date of the entry in the member variable _date of the Entry class
                myEntry._date = dateText;

                // Displays the random prompt and save it in variable
                string prompt = myprompts.GetRandomPrompt();
                Console.WriteLine(prompt);

                // Save prompt in property of the entry class
                myEntry._promptText = prompt;

                // Get entry from user
                string entry = Console.ReadLine();

                // Save the variable entry in the property _entryText 
                myEntry._entryText = entry;

                // Save entry into the journal
                myJournal.AddEntry(myEntry);
            }
            else if (choice == 2) // Display
            {                
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename? ");

                string filename = Console.ReadLine();

                myJournal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename? ");

                string filename = Console.ReadLine();

                myJournal.SaveToFile(filename);

            }


        } while (choice != 5);
    }
}