namespace Common;

public static class UserInteraction
{
    public static string DisplayClassMenu(string name)
    {
        Console.WriteLine($"\nHello {name}, pick your class");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Rogue");
        Console.WriteLine("4. Warlock");
        var choice = Console.ReadLine();
        
        if (string.IsNullOrEmpty(choice))
            Console.WriteLine("Wrong choice");

        return choice!;
    }

    public static string GetCharacterName()
    {
        Console.WriteLine("Enter your character's name: ");
        var name = Console.ReadLine();
        
        if (string.IsNullOrEmpty(name))
            Console.WriteLine("Wrong input");

        return name!;
    }
}