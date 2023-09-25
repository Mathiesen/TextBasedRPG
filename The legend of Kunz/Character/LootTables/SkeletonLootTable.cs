using The_legend_of_Kunz.Items;

namespace The_legend_of_Kunz.Character.LootTables;

public abstract record SkeletonLootTable : ILootTable
{
    public static IEnumerable<IItem> PossibleLoot { get; } = new List<IItem>
    {
        ItemDictionary.GetItem(ItemEnum.BronzeSword),
        ItemDictionary.GetItem(ItemEnum.LargeHealthPotion),
        ItemDictionary.GetItem(ItemEnum.SmallHealthPotion),
        ItemDictionary.GetItem(ItemEnum.SmallBronzeSword),
        ItemDictionary.GetItem(ItemEnum.SmallWoodenBow),
        ItemDictionary.GetItem(ItemEnum.SwordOfThousandTruths),
        ItemDictionary.GetItem(ItemEnum.Gold)
    };
}