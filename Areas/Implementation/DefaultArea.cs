using Areas;

namespace The_legend_of_Kunz.Areas.Implementation;

public class DefaultArea : Area
{
    public DefaultArea()
    {
        Description();
    }

    public override void Description()
    {
        Console.WriteLine("You travel down a long road");
    }

    public override void RandomEncounter()
    {
        throw new NotImplementedException();
    }
}