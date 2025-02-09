public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        do
        {
            DisplayQuestion();
            ShowSpinner(15);        
        } while(DateTime.Now < endTime);

    }

    public void SetPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public void SetQuestion(string question)
    {
        _questions.Add(question);
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();

        int r = rnd.Next(_prompts.Count);

        return $"{_prompts[r]}";
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();

        int r = rnd.Next(_questions.Count);
        return $"{_questions[r]}";
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
    }

    public void DisplayQuestion()
    {
        Console.Write($"{GetRandomQuestion()} ");
        
    }
}