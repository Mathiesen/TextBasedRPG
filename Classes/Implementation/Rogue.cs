using Common;

namespace Classes.Implementation;

public class Rogue : Class
{
    public Rogue(int health, int attack, int defence) 
        : base(health, attack, defence, 0) { }

    public override void FillInventory(IItemDictionary items, ICharacter character)
    {
        throw new NotImplementedException();
    }
}