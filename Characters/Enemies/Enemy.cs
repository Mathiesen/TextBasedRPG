namespace Characters.Enemies;

public class Enemy : Characters.Character
{
    private static Random rng = new();
    
    public override void AttackTarget(Characters.Character target)
    {
        throw new NotImplementedException();
    }

    public override void Defend(int damage)
    {
        throw new NotImplementedException();
    }
}