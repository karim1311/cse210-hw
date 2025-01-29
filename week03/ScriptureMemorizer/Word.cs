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
        _text = new string('_',_text.Length);
        _isHidden = true;
    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return $"{_text}";
    }
}
