using Classes;
using Items;

namespace Characters;

public abstract class Character
{
    public string? Name { get; set; }
    public int Level { get; set; }
    public Class Class { get; set; }
    public Inventory Inventory { get; set; } = new();
    
    public abstract void AttackTarget(Character target);
    public abstract void Defend(int damage);
}