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

    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        return "";
    }
}
