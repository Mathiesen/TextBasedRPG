namespace Common;

public static class UserInteraction
{
    public static ClassEnum DisplayClassMenu(string name)
    {
        Console.WriteLine($"\nHello {name}, pick your class");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Rogue");
        Console.WriteLine("4. Warlock");
        var choice = Console.ReadLine();
        
        if (string.IsNullOrEmpty(choice))
            Console.WriteLine("Wrong choice");



        return Enum.Parse<ClassEnum>(choice!);
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