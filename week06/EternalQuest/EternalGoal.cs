public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name,description,points)
    {
    }


    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    // public override string GetDetailsString()
    // {
    //     return "";
    // }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}:{GetGoalName()},{GetDescription()},{GetPoints()}";
    }
}