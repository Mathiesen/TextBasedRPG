namespace The_legend_of_Kunz.Items.Weapons.Implementation;

public class Sword : IWeapon
{
    private ItemEnum _item;
    
    public Sword(string name, int attack, RarityEnum rarity, int dropChance, ItemEnum item)
    {
        Name = name;
        Attack = attack;
        Rarity = rarity;
        DropChance = dropChance;
        _item = item;
    }

    public string Name { get; init; }
    public RarityEnum Rarity { get; init; }
    public int DropChance { get; init; }
    public int Attack { get; init; }
    public int Defence { get; init; }
    
    public string GetDescription()
    {
        throw new NotImplementedException();
    }
}