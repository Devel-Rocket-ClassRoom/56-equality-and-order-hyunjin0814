using System;

class Monster : IComparable<Monster>
{
    private string Name;
    private int Power;

    public Monster(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public int CompareTo(Monster other)
    {
        if (other == null)
        {
            return 1;
        }
        return Power.CompareTo(other.Power);
    }

    public override string ToString()
    {
        return $"{Name}(전투력:{Power})";
    }
}