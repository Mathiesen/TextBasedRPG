using System.Drawing;
using Pastel;
using The_legend_of_Kunz.Items.Implementation;

namespace The_legend_of_Kunz.Items.Builders;

public class GoldBuilder : IGoldBuilder
{
    private string _name;
    private int _amount;
    private RarityEnum _rarity;
    private int _dropChance;
    private string _description;


    public IItemBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IItemBuilder SetRarity(RarityEnum rarity)
    {
        _rarity = rarity;
        return this;
    }

    public IItemBuilder SetDropChance(int dropChance)
    {
        _dropChance = dropChance;
        return this;
    }

    public IGoldBuilder SetAmount(int amount)
    {
        _amount = amount;
        return this;
    }

    public IItem Build()
    {
        return new Gold(_name, _dropChance, _amount);
    }
}