using Common;

namespace Characters;

public class Player : Character
{
    public Player(IItemDictionary itemDictionary) 
        : base(itemDictionary)
    {
    }
    
    // Get player attack and defense values and attack target 
    // (if target is not dead, then defend against target's attack)
    // (if target is dead, then get loot from target)
    // (if target is not dead, then get attacked by target)
    // (if player is dead, then game over)
    // (if player is not dead, then repeat)
    // (if player is not dead, then level up)
    public override void AttackTarget(ICharacter target)
    {
        var attack = 0;
        var defense = 0;
        var damage = attack - defense;
        target.Defend(damage);
        
        if (target.IsDead)
        {
            var loot = target.Inventory;
            Inventory.Add(loot);
        }
        else
        {
            var targetAttack = 0;
            var targetDefense = 0;
            var targetDamage = targetAttack - targetDefense;
            Defend(targetDamage);
        }
        
        if (IsDead)
        {
            // Game over
        }
        else
        {
            Level++;
        }
    }

    public bool IsDead { get; set; }

    public override void Defend(int damage)
    {
        
    }
}