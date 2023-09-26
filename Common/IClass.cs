using Items;

namespace Common;

public interface IClass
{
    public int Health { get; init; }
    public int Attack { get; init; }
    public int Defence { get; init; }
    public int Mana { get; init; }

    void FillInventory(IItemDictionary items, ICharacter character);
}

public interface IItemDictionary
{
    IItem? GetItem(ItemEnum item);
}