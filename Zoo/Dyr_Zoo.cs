namespace Zoo;

public abstract class Animal
{
    public string Name { get; set; }

    protected Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();
}

public class Lion : Animal
{
    public Lion(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Lion says: Rov!");
    }
}

// Elephant klasse der arver fra Animal
public class Elephant : Animal
{
    public Elephant(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Elephant says: Horn!");
    }
}

// Parrot klasse der arver fra Animal
public class Parrot : Animal
{
    public Parrot(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Parrot says: Hej der!");
    }
}
