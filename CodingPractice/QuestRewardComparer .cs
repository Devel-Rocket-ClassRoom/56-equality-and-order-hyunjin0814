using System.Collections.Generic;

class QuestRewardComparer : Comparer<Quest>
{
    public override int Compare(Quest x, Quest y)
    {
        if (x == null && y == null)
        {
            return 0; 
        }
        if (x == null)
        {
            return -1; 
        }
        if (y == null)
        {
            return 1; 
        }
        return y.RewardGold.CompareTo(x.RewardGold);
    }
}