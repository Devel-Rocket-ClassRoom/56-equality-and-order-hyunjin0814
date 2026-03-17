using System;

class Item : IEquatable<Item>
{
    public string Name;
    public int Id;

    public Item(string name, int id)
    {
        Name = name; Id = id; 
    }

    public bool Equals(Item other)
    {
        if (other == null)
        {
            return false;
        }
        return Id == other.Id && Name == other.Name;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Item);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Id);
    }
}