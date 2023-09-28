using Common;

namespace Items.Implementation;

public class ManaPotion : IItem
{
    private readonly ItemEnum _item;
    private readonly QualityColorMapper _mapper;
    public string Name { get; init; }
    public QualityEnum Quality { get; init; }
    public int DropChance { get; init; }
    public int ManaRestore { get; init; }

    public ManaPotion(string name, QualityEnum quality, int dropChance, int manaRestore, ItemEnum item, QualityColorMapper mapper)
    {
        Name = name;
        Quality = quality;
        DropChance = dropChance;
        ManaRestore = manaRestore;
        _item = item;
        _mapper = mapper;
    }



    public string GetDescription()
    {
        return $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{ManaRestore} Mana";
    }
}