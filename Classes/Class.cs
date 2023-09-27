using Common;

namespace Classes;

public abstract class Class : IClass
{
    protected Class(int health, int attack, int defence, int mana)
    {
        Health = health;
        Attack = attack;
        Defence = defence;
        Mana = mana;
    }
    
    public int Health { get; init; }
    public int Attack { get; init; }
    public int Defence { get; init; }
    public int Mana { get; init; }
    
    public abstract void FillInventory(IItemDictionary items, ICharacter character);
}