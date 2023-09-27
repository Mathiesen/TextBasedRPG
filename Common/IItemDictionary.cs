using Items;

namespace Common;

public interface IItemDictionary
{
    IItem? GetItem(ItemEnum item);
}