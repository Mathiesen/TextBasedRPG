using Areas;

namespace The_legend_of_Kunz.Areas.Implementation;

public class MysticalCave : Area
{
    public MysticalCave()
    {
        Description();
    }
    
    public override void Description()
    {
        Console.WriteLine($"\nIn the distance you see what appears to be a cave." +
                          $" Intrigued, you decide to go and investigate it.");

        RandomEncounter();
        
    }

    public override void RandomEncounter()
    {
        TransitionTo(AreaEnum.DragonLair, AreaEnum.MysticalCave);
    }
}