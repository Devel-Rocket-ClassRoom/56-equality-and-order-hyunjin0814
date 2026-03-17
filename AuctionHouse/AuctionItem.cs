class AuctionItem
{
    public string Name { get; private set; }
    public int CurrentBid { get; private set; }
    public int BidCount { get; private set; }
    public string Category { get; private set; }

    public AuctionItem(string name, int bid, int bidCount, string category)
    {
        Name = name;
        CurrentBid = bid;
        BidCount = bidCount;
        Category = category;
    }

    public override string ToString()
    {
        return $""
    }
}