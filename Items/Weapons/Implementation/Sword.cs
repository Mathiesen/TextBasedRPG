using System.Drawing;
using Pastel;

namespace Items.Weapons.Implementation;

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
        switch (_item)
        {
            case ItemEnum.BronzeSword:
                return $"{Name
                    .Pastel(Color.FromArgb(30, 255, 0))} +{Attack} ATT";
            case ItemEnum.SmallBronzeSword:
                return $"{Name
                    .Pastel(Color.FromArgb(255, 255, 255))} +{Attack} ATT";
            case ItemEnum.SwordOfThousandTruths:
                return $"{Name
                    .Pastel(Color.FromArgb(163, 53, 238))} +{Attack} ATT";
            default:
                return string.Empty;
        }
    }
}