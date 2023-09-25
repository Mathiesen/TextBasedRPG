namespace The_legend_of_Kunz.Items;

public interface IItem
{
    string Name { get; init; }
    RarityEnum Rarity { get; init; }
    int DropChance { get; init; }

    string GetDescription();
}