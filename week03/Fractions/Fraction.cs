public class Fraction 
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

    // END OF CONSTRUCTORS

    public int getTop()
    {
        return _top;
    }

    public void setTop(int top)
    {
        _top = top;
    }

    public int getBotttom()
    {
        return _bottom;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // It will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }


}