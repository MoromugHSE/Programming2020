using System;
using System.IO;

public class Knight : LegendaryHuman
{
    private int equipmentPower;
    public Knight(string name, int healthPoints, int power, string[] equipment) : base(name, healthPoints, power)
    {
        EquipmentPower = equipment.Length;
    }

    public int EquipmentPower
    {
        get => equipmentPower;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Not enough equipment.");
            }
            equipmentPower = value;
        }
    }

    public override string ToString()
    {
        return $"Knight {Name} with HP {HealthPoints}";
    }

    public override void Attack(LegendaryHuman enemy)
    {
        if (HealthPoints <= 0 || enemy.HealthPoints <= 0)
        {
            return;
        }
        Console.WriteLine($"{this} attacked {enemy}.");
        int damage = Power + 10*equipmentPower;
        enemy.HealthPoints -= damage;
        if (enemy.HealthPoints <= 0)
        {
            Console.WriteLine($"{enemy} is dead.");
        }
    

}
}
