using Characters;
using Items;

namespace The_legend_of_Kunz;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the legend of Kunz");

        var game = new Game();
        game.Start(new CharacterFactory(new ItemDictionary(new QualityColorMapper())));
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}