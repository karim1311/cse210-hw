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
    public string NumberOfComments()
    {
        return $"{_comments.Count} Comments";
    }

    public void AddComment(string author, string text)
    {        
        Comment comment  = new Comment(author,text);
        _comments.Add(comment);
    }

    public string SecondsToMinutes(int seconds)
    {
        double totalMinutes = seconds / 60D;
        totalMinutes = Math.Round(totalMinutes,2);
        int wholeMinutes = seconds / 60;
        double remainingSeconds = ((wholeMinutes - totalMinutes) * 60D) * -1;
        remainingSeconds = Math.Round(remainingSeconds);
        return $"{wholeMinutes}:{remainingSeconds}";
    }

    public string GetDisplayText()
    {
        // get the seconds to MM:SS format
        string MMSS = SecondsToMinutes(_seconds);

        // create new string to show all comments
        string allComments ="";
        foreach(Comment comment in _comments)
        {
            allComments += ' ' + comment.GetDisplayText();
        }
        return $"{_title} - {_author}, {MMSS}\n{NumberOfComments()}\n{allComments}";
    }

}