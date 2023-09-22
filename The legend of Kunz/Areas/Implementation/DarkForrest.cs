namespace The_legend_of_Kunz.Areas.Implementation;

public class DarkForrest : Area
{
    private IDictionary<int, string> _forrestEncounters = new Dictionary<int, string>
    {
        {1, "Treasure"},
        {2, "Goblins"},
        {3, "Spooky Encounter"},
        {4, "Herbs"},
        {5, "Skeletons"},
        {6, "Unicorn"}
    };
    public DarkForrest()
    {
        Console.WriteLine($"You find yourself in a dark and dense forrest." +
                          $"The trees seems to whisper secrets.");
    }

    public override void RandomEncounter()
    {
        
    }
}