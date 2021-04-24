using System;

public class Soup
{
    private bool willEat = true;

    public Soup(Ingredient[] ingredients)
    {
        foreach (var ingredient in ingredients)
        {
            if (ingredient is Vegetable vegetable)
            {
                if (vegetable.IsAllergicTo)
                {
                    willEat = false;
                    break;
                }
            }
            if (ingredient is Meat meat)
            {
                if (!meat.IsTasty)
                {
                    willEat = false;
                    break;
                }
            }
        }
    }

    public bool WillEat => willEat;
}