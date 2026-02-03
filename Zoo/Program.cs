using Zoo;

// Opret individuelle dyr
Animal lion = new Lion("Simba");
Animal elephant = new Elephant("Dumbo");
Animal parrot = new Parrot("Polly");

Console.WriteLine("Dyr Lyde:");
lion.MakeSound();
elephant.MakeSound();
parrot.MakeSound();

Console.WriteLine("\nDyr i en Liste");

List<Animal> animals = new List<Animal>
{
    new Lion("Bob"),
    new Elephant("Bob2"),
    new Parrot("Bob3"),
    new Lion("Bob4"),
    new Elephant("Bob5"),
    new Parrot("Bob6")
};

foreach (Animal animal in animals)
{
    animal.MakeSound();
}

Console.WriteLine("\nZoo Status");
Console.WriteLine($"Total animals in zoo: {animals.Count}");
