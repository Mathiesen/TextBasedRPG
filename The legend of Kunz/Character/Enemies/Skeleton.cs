using The_legend_of_Kunz.Classes;

namespace The_legend_of_Kunz.Character.Enemies;

public class Skeleton : Enemy
{
    public Skeleton()
    {
        var clazz = ClassFactory.Create(ClassEnum.Warrior);
        var character = CharacterFactory.CreateCharacter(CharacterEnum.Skeleton);
        character.Inventory.Randomize();
    }
}