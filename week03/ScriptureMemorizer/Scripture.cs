public class Scripture
{
    // ATTRIBUTES
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // CONSTRUCTORS
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(); // split the text into words
        foreach (string word in parts)
        {
            // we create a word object here
            Word wordObj = new Word(word);
            _words.Add(wordObj); // Add them to the list
            // Console.WriteLine(word);
        }
    }

    // END OF CONSTRUCTORS


    // METHODS
    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();

        int r  = rnd.Next(_words.Count);

        while(_words[r].IsHidden()== true)
        {
            // If the random number we got is already hidden, we will generate another number
            // Console.WriteLine("Sorry! Word already hidden, we will choose a different number.");
            r  = rnd.Next(_words.Count);
        }
        _words[r].Hide();
        

        // Console.WriteLine(_words[r].IsHidden());

        Console.WriteLine($"We will hide {numberToHide} words");

        
    }

    public string GetDisplayText()
    {
        string _newText = "";
        foreach(Word word in _words)
        {
            _newText += ' ' + word.GetDisplayText();
        }
        // I need to call the getDisplayText() method in order to get the value
        return $"{_reference.GetDisplayText()} {_newText}";
    }

    public bool IsCompletelyHidden()
    {
        // Check if all boolean values of the _words list are true
        if(_words.All(x => x.IsHidden() == true))
        {
            return true;
        }else
        return false;
    }
}