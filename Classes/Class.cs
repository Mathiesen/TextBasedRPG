namespace Classes;

public abstract class Class
{
    protected Class(int health, int attack, int defence, int mana)
    {
        Health = health;
        Attack = attack;
        Defence = defence;
        Mana = mana;
    }
    
    public int Health { get; protected init; }
    public int Attack { get; protected init; }
    public int Defence { get; protected init; }
    public int Mana { get; protected init; }
}