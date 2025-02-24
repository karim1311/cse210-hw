public class SwimmingActivity : Activity
{
    private int _nLaps;
    public SwimmingActivity(string name, string date, int minutes, int nlaps) : base(name, date, minutes)
    {
        _nLaps = nlaps;
    }

    public override double GetDistance()
    {
        return _nLaps * 50 / 1000; // (km)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}