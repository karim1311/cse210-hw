public class Comment
{
    // ATTRIBUTES
    private string _author;
    private string _text;

    // METHODS
    public string GetDisplayText()
    {
        return $"{_author} ${_text}";
    }
}