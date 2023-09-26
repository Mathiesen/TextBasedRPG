using Common;
using Items;

namespace Classes.Implementation;

public class Warrior : Class
{
    public Warrior(int health, int attack, int defence) 
        : base(health, attack, defence, 0) { }

    public override void FillInventory(IItemDictionary items, ICharacter character)
    {
        character.Inventory.Items.Add(Guid.NewGuid(), items.GetItem(ItemEnum.SmallBronzeSword));
        character.Inventory.Items.Add(Guid.NewGuid(), items.GetItem(ItemEnum.SmallHealthPotion));
        character.Inventory.Items.Add(Guid.NewGuid(), items.GetItem(ItemEnum.SmallHealthPotion));
    }
}