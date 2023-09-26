using System.Drawing;
using Pastel;

namespace Items.Weapons.Implementation;

public class Sword : IWeapon
{
    private ItemEnum _item;
    private QualityColorMapper _mapper;
    
    public Sword(string name, int attack, QualityEnum quality, int dropChance, ItemEnum item, QualityColorMapper mapper)
    {
        Name = name;
        Attack = attack;
        Quality = quality;
        DropChance = dropChance;
        _item = item;
    }

    public string Name { get; init; }
    public QualityEnum Quality { get; init; }
    public int DropChance { get; init; }
    public int Attack { get; init; }
    public int Defence { get; init; }
    
    public string GetDescription()
    {
        switch (_item)
        {
            case ItemEnum.BronzeSword:
                return $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Attack} ATT";
            case ItemEnum.SmallBronzeSword:
                return $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Attack} ATT";
            case ItemEnum.SwordOfThousandTruths:
                return $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Attack} ATT";
            default:
                return string.Empty;
        }
    }
}