using System.Drawing;
using Common;
using Pastel;

namespace Items.Weapons.Implementation;

public class Bow : IWeapon
{
    private ItemEnum _item;
    private readonly QualityColorMapper _mapper;

    public Bow(string name, int attack, QualityEnum quality, int dropChance, ItemEnum item, QualityColorMapper mapper)
    {
        Name = name;
        Attack = attack;
        Quality = quality;
        DropChance = dropChance;
        _item = item;
        _mapper = mapper;
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
            case ItemEnum.SmallWoodenBow:
                return $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Attack} ATT";
            default:
                return string.Empty;
        }
    }
}