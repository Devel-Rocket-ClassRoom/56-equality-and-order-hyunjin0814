class Quest
{
    public string Name { get; private set; }
    public int Priority { get; private set; }
    public int RewardGold { get; private set; }

    public Quest(string name, int priority, int rewardGold)
    {
        Name = name;
        Priority = priority;
        RewardGold = rewardGold;
    }

    public override string ToString()
    {
        return $"[우선순위{Priority}] {Name} (보상:{RewardGold}골드)";
    }
}