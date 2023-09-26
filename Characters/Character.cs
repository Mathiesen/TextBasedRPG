using Common;
using Items;

namespace Characters;

public abstract class Character : ICharacter
{
    public Character(IItemDictionary itemDictionary)
    {
        Inventory = new Inventory(itemDictionary);
    }
    
    public string? Name { get; set; }
    public int Level { get; set; }
    public IClass? Class { get; set; }
    public IInventory Inventory { get; set; }

    public abstract void AttackTarget(ICharacter target);
    public abstract void Defend(int damage);
}