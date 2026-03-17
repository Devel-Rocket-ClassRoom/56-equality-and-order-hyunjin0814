class Equipment
{
    public string Name { get; private set; }
    public string Type { get; private set; }

    public Equipment(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Type}: {Name}";
    }
}