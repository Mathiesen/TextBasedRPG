using System.Security.Cryptography;
using Characters.Enemies;
using Characters.LootTables;
using Characters.Strategies;
using Classes;
using Common;
using Items;

namespace Characters;

public class CharacterFactory
{
    private IDictionary<CharacterEnum, ICharacterCreationStrategy> _strategies;
    private ItemDictionary _items;

    public CharacterFactory(ItemDictionary items)
    {
        _items = items;
        _strategies = new Dictionary<CharacterEnum, ICharacterCreationStrategy>
        {
            {CharacterEnum.Player, new PlayerCreationStrategy()},
            {CharacterEnum.Skeleton, new SkeletonCreationStrategy()}
        };
    }
    
    public ICharacter? CreateCharacter(CharacterEnum characterType, ICharacter? player)
    {
        ICharacter? character = null;

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

    private ICharacter? CreateSkeletonCharacter(ICharacter? player)
    {
       _strategies.TryGetValue(CharacterEnum.Skeleton, out var strategy);
       return strategy!.CreateCharacter(_items);
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
        character.Class.FillInventory(_items, character);

        return character;
    }

    private static IClass HandleClassPick(ClassEnum classChoice) => classChoice switch
    {
        ClassEnum.Warrior => ClassFactory.Create(ClassEnum.Warrior),
        ClassEnum.Mage => ClassFactory.Create(ClassEnum.Mage),
        ClassEnum.Rogue => ClassFactory.Create(ClassEnum.Rogue),
        ClassEnum.Warlock => ClassFactory.Create(ClassEnum.Warlock),
        _ => throw new ArgumentOutOfRangeException(nameof(classChoice), classChoice, null)
    };
}