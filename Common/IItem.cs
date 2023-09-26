namespace Items;

public interface IItem
{
    string Name { get; init; }
    QualityEnum Quality { get; init; }
    int DropChance { get; init; }

    string GetDescription();
}