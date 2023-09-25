using System.Drawing;
using Pastel;

namespace Items.Weapons.Implementation;

public class Bow : IWeapon
{
    private ItemEnum _item;
    public Bow(string name, int attack, RarityEnum rarity, int dropChance, ItemEnum item)
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
        switch (_item)
        {
            case ItemEnum.SmallWoodenBow:
                return $"{Name
                    .Pastel(Color.FromArgb(157, 157, 157))} +{Attack} ATT";
            default:
                return string.Empty;
        }
    }
}