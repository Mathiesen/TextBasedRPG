namespace Items.Implementation;

public class Gold : IItem
{
    private QualityColorMapper _mapper;

    public Gold(string name, int dropChance, int amount, QualityEnum quality, QualityColorMapper mapper)
    {
        Name = name;
        DropChance = dropChance;
        Amount = amount;
        Quality = quality;
        _mapper = mapper;
    }

    public string Name { get; init; }
    public QualityEnum Quality { get; init; }
    public int DropChance { get; init; }
    public int Amount { get; set; }
    public string GetDescription()
    { 
        return $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{Amount}";
    }
}