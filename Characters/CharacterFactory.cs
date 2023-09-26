﻿using System.Security.Cryptography;
using Characters.Enemies;
using Characters.LootTables;
using Classes;
using Classes.Implementation;
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
        var character = new Skeleton
        {
            Class = clazz,
            Level = RandomNumberGenerator.GetInt32(player.Level, player.Level + 3)
        };

        character.Inventory.Randomize(new SkeletonLootTable(_items).PossibleLoot.ToList());

        return character;
    }

    private Character? CreatePlayerCharacter()
    {
        var character = new Player
        {
            Level = 1
        };
        Console.WriteLine("Enter your character's name: ");
        character.Name = Console.ReadLine();
        
        Console.WriteLine($"\nHello {character.Name}, pick your class");
        var classChoice = DisplayClassMenu();
        character.Class = HandleClassPick(classChoice);

        if (character.Class.GetType() == typeof(Warrior))
        {
            FillWarriorInventory(_items, character);
        }
        
        return character;
    }

    private void FillWarriorInventory(ItemDictionary items, Character character)
    {
        character.Inventory.Items.Add(Guid.NewGuid().ToString(), items.GetItem(ItemEnum.SmallBronzeSword));
        character.Inventory.Items.Add(Guid.NewGuid().ToString(), items.GetItem(ItemEnum.SmallHealthPotion));
        character.Inventory.Items.Add(Guid.NewGuid().ToString(), items.GetItem(ItemEnum.SmallHealthPotion));
    }
    
    private static string DisplayClassMenu()
    {
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Rogue");
        Console.WriteLine("4. Warlock");
        var choice = Console.ReadLine();

        return choice;
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