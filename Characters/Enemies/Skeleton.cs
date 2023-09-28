using Common;

namespace Characters.Enemies;

public class Skeleton : Enemy
{
    public Skeleton(IItemDictionary itemDictionary) 
        : base(itemDictionary)
    {
    }

    public override string ToString()
    {
        return $"Level {Level} {Name} {Class}";
    }
}