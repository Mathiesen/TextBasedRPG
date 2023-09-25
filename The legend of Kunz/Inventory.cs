using System.Security.Cryptography;
using The_legend_of_Kunz.Items;
using The_legend_of_Kunz.Items.Implementation;

namespace The_legend_of_Kunz;

public class Inventory
{
    public IDictionary<string, IItem> Items;

    private static readonly Random rng = new();

    public Inventory()
    {
        Items = new Dictionary<string, IItem>();
    }

    public void Randomize(List<IItem> possibleLoot)
    {
        foreach (var item in possibleLoot)
        {
            var randomValue = rng.Next(1, 101);

            if (randomValue <= item.DropChance)
            {
                if (item.GetType() == typeof(Gold))
                {
                    var gold = item as Gold;
                    gold!.Amount = RandomNumberGenerator.GetInt32(1, 11);
                    Items.Add(Guid.NewGuid().ToString(), gold);
                }
                else
                {
                    Items.Add(Guid.NewGuid().ToString(), item);    
                }
            }
                
        }
    }
}