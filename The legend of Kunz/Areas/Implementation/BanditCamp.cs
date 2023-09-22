namespace The_legend_of_Kunz.Areas.Implementation;

public class BanditCamp : Area
{
    public BanditCamp()
    {
        Console.WriteLine($"\nYou stumble upon a bandit camp " +
                          $"and the residents do not look all that friendly");
    }
    
    public override void RandomEncounter()
    {
        throw new NotImplementedException();
    }
}