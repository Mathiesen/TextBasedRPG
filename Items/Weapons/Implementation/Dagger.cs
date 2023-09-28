using Common;

namespace Items.Weapons.Implementation;

public class Dagger : IWeapon
{
    private readonly QualityColorMapper _mapper;
    private readonly ItemEnum _item;
    public string Name { get; init; }
    public QualityEnum Quality { get; init; }
    public int DropChance { get; init; }

    public Dagger(string name, QualityEnum quality, int dropChance, int attack, int defence, ItemEnum item, QualityColorMapper mapper)
    {
        Name = name;
        Quality = quality;
        DropChance = dropChance;
        Attack = attack;
        Defence = defence;
        _mapper = mapper;
        _item = item;
    }

    public string GetDescription()
    {
        return _item switch
        {
            ItemEnum.SmallDagger => $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Attack} ATT",
            _ => string.Empty
        };
    }

    public int Attack { get; init; }
    public int Defence { get; init; }
}