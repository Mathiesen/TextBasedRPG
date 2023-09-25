namespace The_legend_of_Kunz.Areas.Implementation;

public class BlockedByStream : Area
{
    public BlockedByStream()
    {
        Description();
    }
    
    public override void Description()
    {
        Console.WriteLine($"\nYou come up to wide river, there is no way to get across." +
                          $"But at least you can get something to drink.");
    }

    public override void RandomEncounter()
    {
        throw new NotImplementedException();
    }
}