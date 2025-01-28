public class Scripture
{
    // ATTRIBUTES
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    // CONSTRUCTORS
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split();
        foreach (string word in parts)
        {
            // we create an object here
            Word wordObj = new Word(word);
            _words.Add(wordObj);
            // Console.WriteLine(word);
        }
    }

    // END OF CONSTRUCTORS


    // METHODS
    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();

        int r  = rnd.Next(_words.Count);

        _words[r].Hide();

        // Console.WriteLine(_words[r].Hide());

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
        return true;
    }
}