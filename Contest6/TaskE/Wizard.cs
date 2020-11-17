using System;
using System.IO;
using System.Collections;

public class Wizard : LegendaryHuman
{
    string rank;
    int numericalRank;

    public static int NumberByRank(string rank)
    {
        switch(rank)
        {
            case "Neophyte":
                {
                    return 1;
                }
            case "Adept":
                {
                    return 2;
                }
            case "Charmer":
                {
                    return 3;
                }
            case "Sorcerer":
                {
                    return 4;
                }
            case "Master":
                {
                    return 5;
                }
            case "Archmage":
                {
                    return 6;
                }
            default:
                {
                    throw new ArgumentException("Invalid wizard rank.");
                }
        }
    }
    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints,
        power)
    {
        Rank = rank;
        NumericalRank = NumberByRank(rank);
    }

    public string Rank
    {
        get => rank;
        private set
        {
            rank = value;
        }
    }

    public int NumericalRank
    {
        get => numericalRank;
        private set
        {
            numericalRank = value;
        }
    }

    public override string ToString()
    {
        return $"{rank} Wizard {Name} with HP {HealthPoints}";
    }

    public override void Attack(LegendaryHuman enemy)
    {
        if (HealthPoints <= 0 || enemy.HealthPoints <= 0)
        {
            return;
        }
        Console.WriteLine($"{this} attacked {enemy}.");
        int damage = Power * (int)Math.Pow(numericalRank, 1.5) + HealthPoints / 10;
        enemy.HealthPoints -= damage;
        if (enemy.HealthPoints <= 0)
        {
            Console.WriteLine($"{enemy} is dead.");
        }
    }
}