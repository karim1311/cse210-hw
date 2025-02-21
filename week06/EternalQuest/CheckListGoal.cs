public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;

    }

    public override bool IsComplete()
    {
        if (_amountCompleted ==  _target)
        {
            return true;    
        }
        return false;
    }

    public override string GetDetailsString()
    {
        string isChecked = "[ ]";
        if (IsComplete() == true)
        {
            isChecked = "[X]";
        }
        return $"{isChecked} {GetGoalName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}:{GetGoalName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }


}