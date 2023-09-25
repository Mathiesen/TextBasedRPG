using Areas;

namespace The_legend_of_Kunz;

public class Exploration
{
    private static readonly Random _rng = new();

    private Exploration()
    {
    }

    public static void ExploreArea()
    {
        var whereToExplore = _rng.Next(1, 11);
        var area = AreaFactory.CreateArea(whereToExplore);
    }
}