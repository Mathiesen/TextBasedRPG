using Common;

namespace Classes.Implementation;

public class Warlock : Class
{
    public Warlock(int health, int defence, int attack, int mana) 
        : base(health, attack, defence, mana) { }

    public override void FillInventory(IItemDictionary items, ICharacter character)
    {
        throw new NotImplementedException();
    }
}