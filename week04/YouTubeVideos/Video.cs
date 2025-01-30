public class Video
{
    // ATTRIBUTES
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments = new List<Comment>();

    // CONSTRUCTORS
    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    // METHODS
    public void NumberOfComments()
    {
        // int comments =  _comments.Count;
        Console.WriteLine($"The number of comments is  {_comments.Count}");
    }

    public void AddComment()
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

}