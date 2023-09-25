namespace The_legend_of_Kunz.Areas.Implementation;

public class BlockedByLog : Area
{
    public BlockedByLog()
    {
        Description();
    }
    
    public override void Description()
    {
        Console.WriteLine($"\nThe road in front of you is blocked by a fallen tree. " +
                          $"Maybe there is a way around?");
    }

    public override void RandomEncounter()
    {
        throw new NotImplementedException();
    }
}