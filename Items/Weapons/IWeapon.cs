namespace Items.Weapons;

public interface IWeapon : IItem
{
    public int Attack { get; init; }
    public int Defence { get; init; }
}