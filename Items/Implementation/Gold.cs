using System.Drawing;
using Pastel;

namespace Items.Implementation;

public class Gold : IItem
{
    public Gold(string name, int dropChance, int amount)
    {
        Name = name;
        DropChance = dropChance;
        Amount = amount;
    }

    public string Name { get; init; }
    public RarityEnum Rarity { get; init; }
    public int DropChance { get; init; }
    public string GetDescription()
    {
        return $"{Name
            .Pastel(Color.FromArgb(212, 175, 55))} +{Amount}";
    }

    public int Amount { get; set; }
}