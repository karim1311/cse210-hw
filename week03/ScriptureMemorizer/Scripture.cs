public class Scripture
{
    // ATTRIBUTES
    // private Reference = new Reference(chapter);
    private List<Word> _words = new List<Word>();

    private string _text;


    // CONSTRUCTORS
    public Scripture(Reference reference,string text)
    {
        // Reference ref1 = new Reference();
        _text = text;

        
    }

    // END OF CONSTRUCTORS


    // METHODS
    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}