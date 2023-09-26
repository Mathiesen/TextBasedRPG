namespace Common;

public interface ICharacter
{
    public string? Name { get; set; }
    public int Level { get; set; }
    public IClass? Class { get; set; }
    public IInventory Inventory { get; set; }
    
    public void AttackTarget(ICharacter target);
    public void Defend(int damage);
}