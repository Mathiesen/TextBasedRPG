namespace The_legend_of_Kunz.Areas.Implementation;

public class DragonLair : Area
{
    private readonly AreaEnum _from;
    public DragonLair(AreaEnum from = AreaEnum.Undefined)
    {
        _from = from;
        Description();
    }
    
    public override void Description()
    {
        if (_from == AreaEnum.MysticalCave)
        {
            Console.WriteLine($"As you venture into the cave, you find yourself in a Dragons lair. ");
            Console.ReadLine();
        }
    }

    public override void RandomEncounter()
    {
        throw new NotImplementedException();
    }
}