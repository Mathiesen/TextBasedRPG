using Classes;
using Common;

namespace Characters.Strategies;

public abstract class CharacterCreationStrategy : ICharacterCreationStrategy
{
    public abstract ICharacter CreateCharacter(IItemDictionary items);

    public IClass HandleClassPick(ClassEnum classChoice) => classChoice switch
    {
        ClassEnum.Warrior => ClassFactory.Create(ClassEnum.Warrior),
        ClassEnum.Mage => ClassFactory.Create(ClassEnum.Mage),
        ClassEnum.Rogue => ClassFactory.Create(ClassEnum.Rogue),
        ClassEnum.Warlock => ClassFactory.Create(ClassEnum.Warlock),
        _ => throw new ArgumentOutOfRangeException(nameof(classChoice), classChoice, null)
    };
}