using Items.Implementation;
using Items.Weapons.Implementation;

namespace Items.Builders;

public class ItemBuilder : IItemBuilder
{
    private QualityEnum _quality;
    private int _dropChance;
    private ItemEnum _item;
    private QualityColorMapper _mapper;

    public ItemBuilder(QualityColorMapper mapper)
    {
        _mapper = mapper;
    }

    public IItemBuilder SetQuality(QualityEnum quality)
    {
        _quality = quality;
        return this;
    }

    public IItemBuilder SetDropChance(int dropChance)
    {
        _dropChance = dropChance;
        return this;
    }

    public IItemBuilder SetItemEnum(ItemEnum item)
    {
        _item = item;
        return this;
    }

    public IItem Build()
    {
        switch (_item)
        {
            case ItemEnum.SmallHealthPotion:
                return new HealthPotion(
                    "Small health potion",
                    _quality,
                    _dropChance,
                    _item, 
                    15,
                    _mapper);
            case ItemEnum.LargeHealthPotion:
                return new HealthPotion(
                    "Large health potion",
                    _quality,
                    _dropChance,
                    _item,
                    25,
                    _mapper);
            case ItemEnum.SmallManaPotion:
                return new ManaPotion(
                    "Small mana potion",
                    _quality,
                    _dropChance,
                    15,
                    _item,
                    _mapper);
            default:
                throw new ArgumentException();
        }            
    }
}