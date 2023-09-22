namespace The_legend_of_Kunz.Weapons.Implementation;

public class Sword : IWeapon
{
    public Sword(string name, int attack, int defence)
    {
        Name = name;
        Attack = attack;
        Defence = defence;
    }

    public string Name { get; init; }
    public int Attack { get; init; }
    public int Defence { get; init; }

    public override string ToString()
    {
        return $"{Name} +{Attack} ATT";
    }
}