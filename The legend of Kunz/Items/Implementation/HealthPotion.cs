using System.Drawing;
using Pastel;

namespace The_legend_of_Kunz.Items.Implementation;

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
                .Pastel(Color.FromArgb(212, 175, 55))} +{15} HP";
        }

        return $"{Name
            .Pastel(Color.FromArgb(212, 175, 55))} +{25} HP";
    }
    
    public string Name { get; init; }
    public RarityEnum Rarity { get; init; }
    public int DropChance { get; init; }
}