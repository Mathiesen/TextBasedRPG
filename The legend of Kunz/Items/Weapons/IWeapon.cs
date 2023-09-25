namespace The_legend_of_Kunz.Items.Weapons;

public interface IWeapon : IItem
{
    public int Attack { get; init; }
    public int Defence { get; init; }
}