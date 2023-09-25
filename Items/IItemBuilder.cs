namespace Items;

public interface IItemBuilder
{
    IItemBuilder SetName(string name);
    IItemBuilder SetRarity(RarityEnum rarity);
    IItemBuilder SetDropChance(int dropChance);
    IItem Build();
}