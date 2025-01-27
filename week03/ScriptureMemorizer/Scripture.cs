public class Scripture
{
    // ATTRIBUTES
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    // CONSTRUCTORS
    public Scripture(Reference reference,string text)
    {
        _reference = reference;
        
        _words = text;
    }

    // END OF CONSTRUCTORS


    // METHODS
    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return $"{_reference} {_words}";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}