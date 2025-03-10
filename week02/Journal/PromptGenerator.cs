using System.Collections.Generic;

public class PromptGenerator 
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        // Generate a random number from 0 to 4
        // Get a random # from the computer, done by
        // creating an instance of the Random Class, and then using it to get the next integer
        // in a particular range.
        Random randomGenerator = new Random();
        // its not showing the last prompt thats why the 5 
        int promptNumber = randomGenerator.Next(0,5);

        return $"{_prompts[promptNumber]}";
    }
}