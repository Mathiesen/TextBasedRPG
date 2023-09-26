using Common;

namespace Classes.Implementation;

public class Mage : Class
{
    public Mage(int health, int attack, int defence, int mana) 
        : base(health, attack, defence, mana) { }

    public override void FillInventory(IItemDictionary items, ICharacter character)
    {
        throw new NotImplementedException();
    }
}