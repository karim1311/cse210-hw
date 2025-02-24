public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string name, string date, int minutes, double speed) : base(name,date,minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetMinutes();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}