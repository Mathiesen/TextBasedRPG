﻿using Items;

namespace Common;

public interface IInventory
{
    public IDictionary<Guid, IItem> Items { get; set; }
    void Randomize(IList<IItem> possibleLoot);
    void GiveItem(ItemEnum item);
    void GiveItem(ItemEnum item, int quantity);
    void Add(IInventory loot);
}