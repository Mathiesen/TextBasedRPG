namespace The_legend_of_Kunz.Weapons;

public interface IWeapon
{
    string Name { get; init; }
    public int Attack { get; init; }
    public int Defence { get; init; }
}