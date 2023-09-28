using Common;

namespace Classes.Implementation;

public class Warrior : Class
{
    public Warrior(int health, int attack, int defence)
        : base(health, attack, defence, 0)
    {
    }

    public override void FillInventory(IItemDictionary items, ICharacter character)
    {
        character.Inventory.GiveItem(ItemEnum.SmallBronzeSword);
        character.Inventory.GiveItem(ItemEnum.SmallHealthPotion);
        character.Inventory.GiveItem(ItemEnum.SmallHealthPotion);
        character.Inventory.GiveItem(ItemEnum.Gold, 1);
    }

    public override string ToString()
    {
        return nameof(Warrior);
    }
}