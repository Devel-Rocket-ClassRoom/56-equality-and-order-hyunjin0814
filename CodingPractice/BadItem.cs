class BadItem
{
    private string Name;

    public BadItem(string name)
    {
        Name = name; 
    }

    public override bool Equals(object obj)
    {
        BadItem other = obj as BadItem;
        if (other == null)
        {
            return false;
        }
        return Name == other.Name;
    }
}