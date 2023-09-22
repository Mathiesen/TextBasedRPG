namespace The_legend_of_Kunz.Classes;

internal class ClassFactory
{
    public static Class Create(ClassEnum _class)
    {
        return _class switch
        {
            ClassEnum.Warrior => new Warrior(100, 60, 80),
            ClassEnum.Warlock => new Warlock(100, 45, 50, 100),
            ClassEnum.Rogue => new Rogue(100, 40, 50),
            ClassEnum.Mage => new Mage(100, 50, 50, 100),
            _ => null
        };
    }
}