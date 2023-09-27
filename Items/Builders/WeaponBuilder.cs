using Items.Implementation;
using Items.Weapons.Implementation;

namespace Items.Builders;

public class WeaponBuilder : IWeaponBuilder
{
    private QualityEnum _quality;
    private int _dropChance;
    private ItemEnum _item;
    private int _attack;
    private int _defence;
    private readonly QualityColorMapper _mapper;

    public WeaponBuilder(QualityColorMapper mapper)
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
    
    public IWeaponBuilder SetAttack(int attack)
    {
        _attack = attack;
        return this;
    }

    public IWeaponBuilder SetDefence(int defence)
    {
        _defence = defence;
        return this;
    }

    public IItem Build()
    {
        switch (_item)
        {
            case ItemEnum.SmallBronzeSword:
                return new Sword(
                    "Small bronze sword",
                    _attack,
                    _quality,
                    _dropChance,
                    _item,
                    _mapper);
            case ItemEnum.BronzeSword:
                return new Sword(
                    "Bronze sword",
                    _attack,
                    _quality,
                    _dropChance,
                    _item,
                    _mapper);
            case ItemEnum.SmallWoodenBow:
                return new Bow(
                    "Small wooden bow",
                    _attack,
                    _quality,
                    _dropChance,
                    _item,
                    _mapper);
            case ItemEnum.SwordOfThousandTruths:
                return new Sword(
                    "The sword of a thousand truhts",
                    _attack,
                    _quality,
                    _dropChance,
                    _item,
                    _mapper);
            case ItemEnum.WoodenStaff:
                return new Staff(
                    "Wooden staff",
                    _quality,
                    _dropChance,
                    _attack,
                    _defence,
                    _item,
                    _mapper);
            default:
                throw new ArgumentException();
        }            
    }

    
}