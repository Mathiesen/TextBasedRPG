using System.Drawing;
using Pastel;

namespace Items.Implementation;

public class HealthPotion : IItem
{
    private ItemEnum _item;
    
    public HealthPotion(string name, RarityEnum rarity, int dropChance, ItemEnum item)
    {
        Name = name;
        Rarity = rarity;
        DropChance = dropChance;
        _item = item;
    }

    public string GetDescription()
    {
        if (_item == ItemEnum.SmallHealthPotion)
        {
            return $"{Name
                .Pastel(Color.FromArgb(255, 255, 255))} +{15} HP";
        }

        return $"{Name
            .Pastel(Color.FromArgb(255, 255, 255))} +{25} HP";
    }
    
    public string Name { get; init; }
    public RarityEnum Rarity { get; init; }
    public int DropChance { get; init; }
}