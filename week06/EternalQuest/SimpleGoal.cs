using System.Drawing;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name,description,points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
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