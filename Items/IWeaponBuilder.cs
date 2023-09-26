namespace Items;

public interface IWeaponBuilder : IItemBuilder
{
    IWeaponBuilder SetAttack(int attack);
    IWeaponBuilder SetDefence(int defence);
}