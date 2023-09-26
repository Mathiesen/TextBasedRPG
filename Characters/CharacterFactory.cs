using System.Security.Cryptography;
using Characters.Enemies;
using Characters.LootTables;
using Classes;
using Classes.Implementation;
using Common;
using Items;

namespace Characters;

public class CharacterFactory
{
    private ItemDictionary _items;

    public CharacterFactory(ItemDictionary items)
    {
        _items = items;
    }
    
    public Character? CreateCharacter(CharacterEnum characterType, Character? player)
    {
        Character? character = null;

        switch (characterType)
        {
            case CharacterEnum.Player:
                character = CreatePlayerCharacter();
                break;
            case CharacterEnum.Skeleton:
                character = CreateSkeletonCharacter(player);
                break;
            case CharacterEnum.Goblin:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(characterType), characterType, null);
        }

        return character;
    }

    private Character? CreateSkeletonCharacter(Character? player)
    {
        var clazz = ClassFactory.Create(ClassEnum.Warrior);
        var character = new Skeleton(_items)
        {
            Class = clazz,
            Level = RandomNumberGenerator.GetInt32(player.Level, player.Level + 3)
        };

        character.Inventory.Randomize(new SkeletonLootTable(_items).PossibleLoot.ToList());

        return character;
    }

    private Character? CreatePlayerCharacter()
    {
        var character = new Player(_items)
        {
            Level = 1,
            Name = UserInteraction.GetCharacterName()
        };

        var classChoice = UserInteraction.DisplayClassMenu(character.Name);
        character.Class = HandleClassPick(classChoice);

        if (character.Class.GetType() == typeof(Warrior))
        {
            character.Class.FillInventory(_items, character);
        }
        
        return character;
    }

    private static Class HandleClassPick(string? choice)
    {
        return (choice switch
        {
            "1" => ClassFactory.Create(ClassEnum.Warrior),
            "2" => ClassFactory.Create(ClassEnum.Mage),
            "3" => ClassFactory.Create(ClassEnum.Rogue),
            "4" => ClassFactory.Create(ClassEnum.Warlock),
            _ => null
        })!;
    }
}