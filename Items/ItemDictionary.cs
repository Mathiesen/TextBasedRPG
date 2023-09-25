using Items.Builders;
using Items.Implementation;
using Items.Weapons.Implementation;

namespace Items;

public static class ItemDictionary
{
    private static readonly IDictionary<ItemEnum, IItem> Items = new Dictionary<ItemEnum, IItem>
    {
        { ItemEnum.Gold, new GoldBuilder()
            .SetAmount(10)
            .SetName("Gold")
            .SetRarity(RarityEnum.Common)
            .SetDropChance(60)
            .Build() },
        { ItemEnum.SmallHealthPotion, new HealthPotion("Small health potion", RarityEnum.Common, 25, ItemEnum.SmallHealthPotion) },
        { ItemEnum.LargeHealthPotion, new HealthPotion("Large health potion", RarityEnum.Common, 25, ItemEnum.LargeHealthPotion) },
        { ItemEnum.SmallBronzeSword, new Sword("Small bronze sword", 15, RarityEnum.Common, 25, ItemEnum.SmallBronzeSword) },
        { ItemEnum.BronzeSword, new Sword("Bronze sword", 20, RarityEnum.Uncommon, 15, ItemEnum.BronzeSword) },
        { ItemEnum.SmallWoodenBow, new Bow("Small wooden bow", 10, RarityEnum.Poor, 50, ItemEnum.SmallWoodenBow) },
        { ItemEnum.SwordOfThousandTruths, new Sword("The sword of a thousand truths", 100, RarityEnum.Epic, 100, ItemEnum.SwordOfThousandTruths) }
    };

    public static IItem GetItem(ItemEnum item)
    {
        return Items[item];
    }
}