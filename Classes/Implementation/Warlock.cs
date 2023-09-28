using Common;
using Items;

namespace Classes.Implementation;

public class Warlock : Class
{
    public Warlock(int health, int defence, int attack, int mana) 
        : base(health, attack, defence, mana) { }

    public override void FillInventory(IItemDictionary items, ICharacter character)
    {
        character.Inventory.GiveItem(ItemEnum.WoodenStaff);
        character.Inventory.GiveItem(ItemEnum.SmallHealthPotion);
        character.Inventory.GiveItem(ItemEnum.SmallHealthPotion);
        character.Inventory.GiveItem(ItemEnum.SmallManaPotion);
        character.Inventory.GiveItem(ItemEnum.Gold, 1);
    }

    public override string ToString()
    {
        return nameof(Warlock);
    }
}