public abstract class Activity
{
    private string _name;
    private string _date;
    private int _minutes;

    public Activity(string name, string date, int minutes)
    {
        _name = name;
        _date = date;
        _minutes = minutes;
    }

    // I will use Kilometers

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed(); 
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

}