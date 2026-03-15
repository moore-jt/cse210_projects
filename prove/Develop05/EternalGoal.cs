using System;
using System.ComponentModel.DataAnnotations;

public class EternalGoal : Goal
{
    private int _timesMarked;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesMarked = 0;
    }

    public override int RecordEvent()
    {
        _timesMarked++;
        return _points;
    }

    public override bool IsComplete()
    {
        return false;   
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points},{_timesMarked}";
    }


}