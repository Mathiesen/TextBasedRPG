using The_legend_of_Kunz.Character.Enemies;
using The_legend_of_Kunz.Classes;
using The_legend_of_Kunz.Implementation;
using The_legend_of_Kunz.Weapons.Implementation;

namespace The_legend_of_Kunz.Character;

internal static class CharacterFactory
{
    public static Character CreateCharacter(CharacterEnum characterType)
    {
        Character character = null;

        switch (characterType)
        {
            case CharacterEnum.Player:
                character = CreatePlayerCharacter();
                break;
            case CharacterEnum.Skeleton:
                character = new Skeleton();
                break;
            case CharacterEnum.Goblin:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(characterType), characterType, null);
        }

        return character;
    }

    private static Character CreatePlayerCharacter()
    {
        var character = new Player();
        character.Level = 1;
        Console.WriteLine("Enter your character's name: ");
        character.Name = Console.ReadLine();
        
        Console.WriteLine($"\nHello {character.Name}, pick your class");
        var classChoice = DisplayClassMenu();
        character.Class = HandleClassPick(classChoice);

        if (character.Class.GetType() == typeof(Warrior))
        {
            character.Inventory.Weapons
                .Add(Guid.NewGuid().ToString(), new Sword(
                    "Short copper sword",
                    10,
                    0));
            character.Inventory.Items.Add(Guid.NewGuid().ToString(), new HealthPotion("Small health potion"));
            character.Inventory.Items.Add(Guid.NewGuid().ToString(), new HealthPotion("Small health potion"));
        }
        
        return character;
    }
    
    private static string DisplayClassMenu()
    {
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Rogue");
        Console.WriteLine("4. Warlock");
        string choice = Console.ReadLine();

        return choice;
    }
    
    private static Class HandleClassPick(string? choice)
    {
        switch (choice)
        {
            case "1":
                return ClassFactory.Create(ClassEnum.Warrior);
            case "2":
                return ClassFactory.Create(ClassEnum.Mage);
            case "3":
                return ClassFactory.Create(ClassEnum.Rogue);
            case "4":
                return ClassFactory.Create(ClassEnum.Warlock);
            default:
                return null;
        }
    }
}