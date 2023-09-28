using Common;

namespace Items;

public interface IItemBuilder
{
    IItemBuilder SetQuality(QualityEnum quality);
    IItemBuilder SetDropChance(int dropChance);
    IItemBuilder SetItemEnum(ItemEnum item);
    IItem Build();
}