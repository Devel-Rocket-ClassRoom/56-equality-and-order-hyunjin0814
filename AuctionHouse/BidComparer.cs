using System.Collections.Generic;
using System.Diagnostics;

class BidComparer : Comparer<AuctionItem>
{
    public override int Compare(AuctionItem x, AuctionItem y)
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

        int result = x.CurrentBid.CompareTo(y.CurrentBid);
        if (result != 0)
        {
            return result;
        }

        return y.Name.CompareTo(x.Name);

    }
}