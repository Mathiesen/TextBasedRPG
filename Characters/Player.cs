using Common;

namespace Characters;

public class Player : Character
{
    public Player(IItemDictionary itemDictionary) 
        : base(itemDictionary)
    {
    }
    
    public override void AttackTarget(ICharacter target)
    {
        throw new NotImplementedException();
    }

    public override void Defend(int damage)
    {
        throw new NotImplementedException();
    }
}