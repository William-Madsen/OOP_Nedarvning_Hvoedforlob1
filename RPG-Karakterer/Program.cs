using ClassLibrary1;

class Program
{
    static void Main(string[] args)
    {
        // Opret karakterer
        var warrior = new Warrior("Bob Krigerne", 100, 15);
        var mage = new Mage("Tom Troldmanden", 80, 20);
        
        Console.WriteLine("RPG Kamp Simulation");
        Console.WriteLine();
        
        // Vis karakter information
        Console.WriteLine("Karakterer:");
        Console.WriteLine($"Warrior: {warrior.Name} - HP: {warrior.Health}, Strength: {warrior.Strength}");
        Console.WriteLine($"Mage: {mage.Name} - HP: {mage.Health}, Mana: {mage.Mana}");
        Console.WriteLine();
        
        // Start kampen
        CombatSimulation.Fight(warrior, mage);
        
    }
}
