using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Step 1: Design the Classes
        // Class: Job
        // Responsibilities:
        // Keeps track of the company,job title, start year, and end year.
        // Behaviors:
        // Displays the job information in the format "Job title (Company) StartYear-EndYear", for example:
        // "Software Engineer (Microsoft) 2019-2022"

        // Class: Resume
        // Responsibilities:
        // Keeps track of the person's name and a list of their jobs.
        // Behaviors
        // Displays the resume, which shows the name first, followed by displaying each one of the jobs.

        // Based on these descriptions, you could create a class diagrams like the following:

        // Resume
        // _name : string
        // _jobs : List<Job>

        // Display() : void

        // Job
        // _company : string
        // _jobTitle : string
        // _startYear : int
        // _endYear : int

        // Display() : void

        Job job1 = new Job();
        job1._company = "ASaplicaciones";
        job1._jobTitle = "Systems Clerk";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Astorga Yañez y Rodriguez";
        job2._jobTitle = "Accountant Clerk";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume myResume = new Resume();
        myResume._name = "Karim Valenzuela";

        // The Resume class has a variable list named _jobs and we are adding jobs to that empty list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}