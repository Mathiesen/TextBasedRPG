namespace Items.Implementation;

public class Gold : IItem
{
    private QualityColorMapper _mapper;
    private readonly ItemConfigReader _reader;

    public Gold(string name, int dropChance, int amount, QualityEnum quality, QualityColorMapper mapper, ItemConfigReader reader)
    {
        Name = name;
        DropChance = dropChance;
        Amount = amount;
        Quality = quality;
        _mapper = mapper;
        _reader = reader;
    }

    public string Name { get; init; }
    public QualityEnum Quality { get; init; }
    public int DropChance { get; init; }
    public int Amount { get; set; }
    public string GetDescription()
    { 
        return $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Amount}";
    }

    public IItem BuildItem(string itemType, IItemBuilder builder)
    {
        var config = _reader.ReadConfig()![itemType];
        builder
            .SetQuality(Quality)
            .SetDropChance(70)
            .SetItemEnum(ItemEnum.Gold);

        return builder.Build();
    }
}