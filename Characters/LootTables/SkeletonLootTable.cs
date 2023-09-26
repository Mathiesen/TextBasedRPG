using Items;

namespace Characters.LootTables;

public record SkeletonLootTable : ILootTable
{
    public SkeletonLootTable(ItemDictionary items) 
    {
        CreatePossibleLoot(items);
    }

    private void CreatePossibleLoot(ItemDictionary items)
    {
        PossibleLoot = new List<IItem?>
        {
            items.GetItem(ItemEnum.BronzeSword),
            items.GetItem(ItemEnum.LargeHealthPotion),
            items.GetItem(ItemEnum.SmallHealthPotion),
            items.GetItem(ItemEnum.SmallBronzeSword),
            items.GetItem(ItemEnum.SmallWoodenBow),
            items.GetItem(ItemEnum.SwordOfThousandTruths),
            items.GetItem(ItemEnum.Gold)
        };
    }
    
    public IEnumerable<IItem?> PossibleLoot { get; private set; }
    
    
}