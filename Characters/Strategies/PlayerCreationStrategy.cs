using Classes;
using Common;

namespace Characters.Strategies;

public class PlayerCreationStrategy : CharacterCreationStrategy
{
    public override ICharacter CreateCharacter(IItemDictionary items)
    {
        var character = new Player(items)
        {
            Level = 1,
            Name = UserInteraction.GetCharacterName()
        };

        var classChoice = UserInteraction.DisplayClassMenu(character.Name);
        character.Class = HandleClassPick(classChoice);
        character.Class.FillInventory(items, character);

        return character;

    }
}