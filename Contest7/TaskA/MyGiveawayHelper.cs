using System;

internal class MyGiveawayHelper
{
    private int randomNumber = 1579;
    private int currentPrize = 0;
    string[] logins;
    string[] prizes;

    public MyGiveawayHelper(string[] logins, string[] prizes)
    {
        this.logins = logins;
        this.prizes = prizes;
    }

    public bool HasPrizes => currentPrize < prizes.Length;

    private void GenerateNextRandomNumber()
    {
        int nextRandomNumber = randomNumber * randomNumber / 100 % 10000;
        randomNumber = nextRandomNumber;
    }

    public (string prize, string login) GetPrizeLogin()
    {
        GenerateNextRandomNumber();
        return (prizes[currentPrize++], logins[randomNumber % logins.Length]);
    }
}