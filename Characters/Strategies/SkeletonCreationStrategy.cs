using Characters.Enemies;
using Common;

namespace Characters.Strategies;

public class SkeletonCreationStrategy : CharacterCreationStrategy
{
    // Implement character creation for Skeletons here based on player character creation.
    public override ICharacter CreateCharacter(IItemDictionary items)
    {
        var character = new Skeleton(items)
        {
            Level = 1,
            Name = "Skeleton",
            Class = RandomizeClass()
        };

        character.Class.FillInventory(items, character);

        return character;
    }

    private IClass RandomizeClass()
    {
        var random = new Random();
        var classChoice = random.Next(0, 4);
        return HandleClassPick((ClassEnum)classChoice);
    }
}