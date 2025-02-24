public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string name, string date, int minutes,double distance) : base(name,date,minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}