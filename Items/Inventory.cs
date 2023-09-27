using System.Security.Cryptography;
using Common;
using Items.Implementation;

namespace Items;

public class Inventory : IInventory
{
    public IDictionary<Guid, IItem> Items { get; set; }

    private static readonly Random Rng = new();
    private IItemDictionary _itemDictionary;

    public Inventory(IItemDictionary itemDictionary)
    {
        _itemDictionary = itemDictionary;
        Items = new Dictionary<Guid, IItem>();
    }

    public void Randomize(IList<IItem> possibleLoot)
    {
        foreach (var item in possibleLoot)
        {
            var randomValue = Rng.Next(1, 101);

            if (item == null)
                continue;
            
            if (randomValue <= item.DropChance)
            {
                if (item.GetType() == typeof(Gold))
                {
                    var gold = item as Gold;
                    gold!.Amount = RandomNumberGenerator.GetInt32(1, 11);
                    Items.Add(Guid.NewGuid(), gold);
                }
                else
                {
                    Items.Add(Guid.NewGuid(), item);    
                }
            }
                
        }
    }

    public void GiveItem(ItemEnum item)
    {
        Items.Add(Guid.NewGuid(), _itemDictionary.GetItem(item) ?? throw new InvalidOperationException());
    }

    public void GiveItem(ItemEnum item, int quantity)
    {
        var gold = Items
            .Where(x => x.Value.GetType() == typeof(Gold))
            .Select(x => x.Value)
            .FirstOrDefault();

        if (gold == null)
        {
            var gottenGold = _itemDictionary.GetItem(ItemEnum.Gold);
            var newGold = gottenGold as Gold;
            newGold!.Amount = quantity;
            Items.Add(Guid.NewGuid(), newGold);
        }
        else
        {
            var oldGold = gold as Gold;
            oldGold!.Amount += quantity;
        }
        
        
        
    }
}