using The_legend_of_Kunz.Weapons;

namespace The_legend_of_Kunz;

public class Inventory
{
    public readonly IDictionary<string, IItem> Items;
    public readonly IDictionary<string, IWeapon> Weapons;

    public Inventory()
    {
        Items = new Dictionary<string, IItem>();
        Weapons = new Dictionary<string, IWeapon>();
    }

    public void Randomize()
    {
        throw new NotImplementedException();
    }
}