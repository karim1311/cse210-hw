using System.Drawing;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name,description,points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name,description,points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        _isComplete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        // if (_isComplete == true)
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string isChecked = "[ ]";
        if (IsComplete() == true)
        {
            isChecked = "[X]";
        }

        return $"{isChecked} {GetGoalName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}:{GetGoalName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
}