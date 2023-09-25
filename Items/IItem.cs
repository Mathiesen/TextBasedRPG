namespace Items;

public interface IItem
{
    string Name { get; init; }
    RarityEnum Rarity { get; init; }
    int DropChance { get; init; }

    string GetDescription();
}