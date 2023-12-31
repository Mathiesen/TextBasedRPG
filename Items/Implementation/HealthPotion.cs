﻿using System.Drawing;
using Common;
using Pastel;

namespace Items.Implementation;

public class HealthPotion : IItem
{
    private ItemEnum _item;
    private readonly QualityColorMapper _mapper;

    public HealthPotion(string name, QualityEnum quality, int dropChance, ItemEnum item, int healthRetore, QualityColorMapper mapper)
    {
        Name = name;
        Quality = quality;
        DropChance = dropChance;
        HealthRestore = healthRetore;
        _item = item;
        _mapper = mapper;
    }

    public string GetDescription()
    {
        return $"{_mapper.ColorizeStringByQuality(Name, Quality)} +{HealthRestore} HP";
    }
    
    public string Name { get; init; }
    public QualityEnum Quality { get; init; }
    public int DropChance { get; init; }
    public int HealthRestore { get; init; }
}