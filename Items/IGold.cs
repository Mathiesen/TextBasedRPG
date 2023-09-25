namespace Items;

public interface IGold : IItem
{
    public int Amount { get; init; }
}