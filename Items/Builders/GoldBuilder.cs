using Common;
using Items.Implementation;

namespace Items.Builders;

public class GoldBuilder : IGoldBuilder
{
    private int _amount;
    private QualityEnum _quality;
    private int _dropChance;
    private string _description;
    private QualityColorMapper _mapper;
    private ItemEnum _item;

    public GoldBuilder(QualityColorMapper mapper)
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

    public IGoldBuilder SetAmount(int amount)
    {
        _amount = amount;
        return this;
    }

    public IItem Build()
    {
        return new Gold("Gold", _dropChance, _amount, _quality, _mapper);
    }
}