using Common;

namespace Characters.Enemies;

public abstract class Enemy : Character
{
    private static Random _rng = new();

    protected Enemy(IItemDictionary itemDictionary) 
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