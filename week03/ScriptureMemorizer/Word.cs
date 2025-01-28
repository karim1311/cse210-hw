public class Word
{
    // ATTRIBUTES
    private string _text;
    private bool _isHidden;

    // CONSTRUCTOR
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // END OF CONSTRUCTOR

    // METHODS
    public void Hide()
    {
        _isHidden = true;
        _text = "___";

    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        return $"{_text}";
    }
}
