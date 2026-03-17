using System.Collections.Generic;

class EquipmentTypeComparer : EqualityComparer<Equipment>
{
    public override bool Equals(Equipment x, Equipment y)
    {
        if (x == null && y == null)
        {
            return true;
        }
        if (x == null || y == null)
        {
            return false; 
        }
        return x.Type == y.Type;
    }

    public override int GetHashCode(Equipment obj)
    {
        return obj?.Type?.GetHashCode() ?? 0; 
    }
}