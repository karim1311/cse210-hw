using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        
        // for(int i = 5; i>0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);

        //     Console.Write("\b \b");
        // }

        // for(int i = 5; i>0; i--)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);

        //     // Console.Write("\b \b");
        // }

        // |/-\|/-\|
        // List<string> animationStrings = new List<string>();
        // animationStrings.Add("|");
        // animationStrings.Add("/");
        // animationStrings.Add("-");
        // animationStrings.Add("\\");
        // animationStrings.Add("|");
        // animationStrings.Add("/");
        // animationStrings.Add("-");
        // animationStrings.Add("\\");

        // foreach(string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(10);

        // int i = 0;

        // while(DateTime.Now < endTime)
        // {
        //     string s = animationStrings[i];
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");

        //     i++;

        //     if(i >= animationStrings.Count)
        //     {
        //         i =0;
        //     }
        // }


        int choice = 0;

        do
        {
            // Display menu and ask user for option
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Start breathing activity.");
            Console.WriteLine(" 2. Start reflecting activity.");
            Console.WriteLine(" 3. Start listing activity.");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            // breathing activity
            if (choice == 1)
            {
                // Instance of the Breathing Activity Class
                BreathingActivity ba1 = new BreathingActivity("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                ba1.DisplayStartingMessage();

                ba1.Run();

                ba1.DisplayEndingMessage();

            } else if (choice == 2) // Reflecting Activity
            {
                // Instance of the Reflecting Activity Class
                ReflectingActivity ra1 = new ReflectingActivity("Reflecting","This activity will help you reflect on times in your life when you have shown stength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                // We will set some prompts here
                ra1.SetPrompt("Think of a time when you stood up for someone else.");
                ra1.SetPrompt("Think of a time when you did something really difficult.");
                ra1.SetPrompt("Think of a time when you helped someone in need.");
                ra1.SetPrompt("Think of a time when you did something truly selfless.");

                // We will set the questions here
                ra1.SetQuestion("Why was this experience meaningful to you?");
                ra1.SetQuestion("Have you ever done anything like this before?");
                ra1.SetQuestion("How did you get started?");
                ra1.SetQuestion("How did you feel when it was complete?");
                ra1.SetQuestion("What made this time different than other times when you were not as successful?");
                ra1.SetQuestion("What is your favorite thing about this experience?");
                ra1.SetQuestion("What could you learn from this experience that applies to other situations?");
                ra1.SetQuestion("What did you learn about yourself through this experience?");
                ra1.SetQuestion("How can you keep this experience in mind in the future?");

                // ra1.SetPrompt("Who are people that you appreciate?");
                // ra1.SetPrompt("What are personal strengths of yours?");
                // ra1.SetPrompt("Who are people that you have helped this week?");
                // ra1.SetPrompt("When have you felt the Holy Ghost this month?");
                // ra1.SetPrompt("Who are some of your personal heroes?");

                ra1.DisplayStartingMessage();

                ra1.Run();

                ra1.DisplayEndingMessage();

            } else if(choice == 3) // Listing Activity
            {
                // Instance of the Listing Activity Class
                ListingActivity la1 = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");


                // We will set the questions here
                la1.SetPrompt("Who are people that you appreciate?");
                la1.SetPrompt("What are personal strengths of yours?");
                la1.SetPrompt("Who are people that you have helped this week?");
                la1.SetPrompt("When have you felt the Holy Ghost this month?");
                la1.SetPrompt("Who are some of your personal heroes?");

                la1.DisplayStartingMessage();

                la1.Run();

                la1.DisplayEndingMessage();

            }
        } while (choice != 4);

        // Console.WriteLine("Done.");
        
    }
}