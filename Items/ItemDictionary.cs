using Items.Builders;
using Items.Implementation;
using Items.Weapons.Implementation;

namespace Items;

public class ItemDictionary
{
    private IDictionary<ItemEnum, IItem> _items = new Dictionary<ItemEnum, IItem>();

    public ItemDictionary(QualityColorMapper mapper)
    {
        InitializeItems(mapper);
    }

    private void InitializeItems(QualityColorMapper mapper)
    {
        _items = new Dictionary<ItemEnum, IItem>
        {
            { ItemEnum.Gold, new GoldBuilder(mapper)
                .SetAmount(10)
                .SetQuality(QualityEnum.Gold)
                .SetDropChance(60)
                .Build() },
            { ItemEnum.SmallHealthPotion, new ItemBuilder(mapper)
                .SetItemEnum(ItemEnum.SmallHealthPotion)
                .SetDropChance(45)
                .SetQuality(QualityEnum.Common)
                .Build()
            },
            { ItemEnum.SmallBronzeSword, new WeaponBuilder(mapper)
                .SetAttack(12)
                .SetDefence(0)
                .SetItemEnum(ItemEnum.SmallBronzeSword)
                .SetQuality(QualityEnum.Common)
                .SetDropChance(50)
                .Build()
            }
        };
    }

    public IItem? GetItem(ItemEnum item)
    {
        _items.TryGetValue(item, out var value);
        return value;
    }
}