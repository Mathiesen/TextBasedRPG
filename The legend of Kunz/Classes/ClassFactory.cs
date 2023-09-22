namespace The_legend_of_Kunz.Classes;

internal class ClassFactory
{
    public static Class Create(ClassEnum _class)
    {
        switch (_class)
        {
            case ClassEnum.Warrior:
                return new Warrior(100, 60, 80);
            case ClassEnum.Warlock:
                return new Warlock(100, 45, 50, 100);
            case ClassEnum.Rogue:
                return new Rogue(100, 40, 50);
            case ClassEnum.Mage:
                return new Mage(100, 50, 50, 100);
            default:
                return null;
        }
    }
}