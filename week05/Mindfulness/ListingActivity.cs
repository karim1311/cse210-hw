public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");

        // We will only need 1 prompt
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        do
        {
            // We will save the response in a variable if we later need to store them
            string userResponse = Console.ReadLine();
            _count++;
        } while(DateTime.Now < endTime);

        Console.WriteLine($"You listed {_count} items!");
    }

     public void SetPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();

        int r = rnd.Next(_prompts.Count);

        // Show the prompt in this random position
        Console.WriteLine($"---- {_prompts[r]} ----");
    }

    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        return listFromUser;
    }
}