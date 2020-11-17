using System;

public static class GiftCreator
{
    public static Gift CreateGift(string giftName)
    {
        if (giftName == "Phone")
        {
            return new Phone();
        }
        return new PlayStation();
    }
}

public class Phone : Gift
{
    private static int nextObjectIndex = 0;

    public Phone() : base(nextObjectIndex++)
    {
    }
}

public class PlayStation : Gift
{
    private static int nextObjectIndex = 0;

    public PlayStation() : base(nextObjectIndex++)
    {
    }
}

