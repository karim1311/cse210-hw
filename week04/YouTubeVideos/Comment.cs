public class Comment
{
    // ATTRIBUTES
    private string _author;
    private string _text;

    // CONSTRUCTOR
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    // END OF CONSTRUCTOR

    // METHODS
    public string GetDisplayText()
    {
        return $"@{_author} : {_text}\n";
    }
}