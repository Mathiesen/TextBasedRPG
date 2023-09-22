namespace The_legend_of_Kunz.Implementation;

public class HealthPotion : IItem
{
    public HealthPotion(string name)
    {
        Name = name;
    }
    public string Name { get; init; }
}