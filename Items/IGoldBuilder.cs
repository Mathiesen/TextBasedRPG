namespace Items;

public interface IGoldBuilder : IItemBuilder
{
    IGoldBuilder SetAmount(int amount);
}