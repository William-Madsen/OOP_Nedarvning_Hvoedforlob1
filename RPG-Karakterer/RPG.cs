namespace ClassLibrary1;

// Basisklasse Character
public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual int Attack()
    {
        return 5; // Basis attack værdi
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}

// Warrior underklasse
public class Warrior : Character
{
    public int Strength { get; set; }

    public Warrior(string name, int health, int strength) : base(name, health)
    {
        Strength = strength;
    }

    public override int Attack()
    {
        return Strength * 2;
    }
}

// Mage underklasse
public class Mage : Character
{
    public int Mana { get; set; }

    public Mage(string name, int health, int mana) : base(name, health)
    {
        Mana = mana;
    }

    public override int Attack()
    {
        return Mana / 2;
    }
}

// Kamp-simulation klasse
public class CombatSimulation
{
    public static void Fight(Character fighter1, Character fighter2)
    {
        Console.WriteLine($"Kamp mellem {fighter1.Name} og {fighter2.Name}!");
        Console.WriteLine($"{fighter1.Name}: {fighter1.Health} HP");
        Console.WriteLine($"{fighter2.Name}: {fighter2.Health} HP");
        Console.WriteLine();

        int round = 1;
        while (fighter1.IsAlive() && fighter2.IsAlive())
        {
            Console.WriteLine($"--- Runde {round} ---");
            
            // Fighter1 angriber fighter2
            int damage1 = fighter1.Attack();
            fighter2.TakeDamage(damage1);
            Console.WriteLine($"{fighter1.Name} angriber {fighter2.Name} for {damage1} skade!");
            Console.WriteLine($"{fighter2.Name} har nu {fighter2.Health} HP tilbage");

            if (!fighter2.IsAlive())
            {
                Console.WriteLine($"{fighter2.Name} er besejret!");
                Console.WriteLine($"{fighter1.Name} vinder kampen!");
                break;
            }

            // Fighter2 angriber fighter1
            int damage2 = fighter2.Attack();
            fighter1.TakeDamage(damage2);
            Console.WriteLine($"{fighter2.Name} angriber {fighter1.Name} for {damage2} skade!");
            Console.WriteLine($"{fighter1.Name} har nu {fighter1.Health} HP tilbage");

            if (!fighter1.IsAlive())
            {
                Console.WriteLine($"{fighter1.Name} er besejret!");
                Console.WriteLine($"{fighter2.Name} vinder kampen!");
                break;
            }

            Console.WriteLine();
            round++;
        }
    }
}
