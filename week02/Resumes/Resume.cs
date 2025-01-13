public class Resume 
{
    public string _name;
    // We create an empty list called _jobs with the characteristics of the Job Class
    public List<Job> _jobs = new List<Job>();

    // This function or method returns nothing so we put void 
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        // Personally I think that we bring the characteristics of the Job class by using Job j and thats why it lets us use the Display() Method
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    } 
}