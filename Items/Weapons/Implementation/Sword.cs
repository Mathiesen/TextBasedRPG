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
        _mapper = mapper;
    }

    public string Name { get; init; }
    public QualityEnum Quality { get; init; }
    public int DropChance { get; init; }
    public int Attack { get; init; }
    public int Defence { get; init; }
    
    public string GetDescription()
    {
        return _item switch
        {
            ItemEnum.BronzeSword => $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Attack} ATT",
            ItemEnum.SmallBronzeSword => $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Attack} ATT",
            ItemEnum.SwordOfThousandTruths => $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Attack} ATT",
            _ => string.Empty
        };
    }
}