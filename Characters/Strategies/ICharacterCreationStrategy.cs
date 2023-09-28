using Classes;
using Common;

namespace Characters.Strategies;

public interface ICharacterCreationStrategy
{
    ICharacter CreateCharacter(IItemDictionary items);
    IClass HandleClassPick(ClassEnum classChoice);
}