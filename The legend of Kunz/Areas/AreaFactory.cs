﻿using The_legend_of_Kunz.Areas.Implementation;

namespace The_legend_of_Kunz.Areas;

public static class AreaFactory
{
    public static Area CreateArea(int areaCode)
    {
        Area returnArea = areaCode switch
        {
            (int)AreaEnum.DarkForrest => new DarkForrest(),
            (int)AreaEnum.Village => new Village(),
            (int)AreaEnum.Ruin => new Ruin(),
            (int)AreaEnum.BanditCamp => new BanditCamp(),
            (int)AreaEnum.MysticalCave => new MysticalCave(),
            (int)AreaEnum.DragonLair => new DragonLair(),
            (int)AreaEnum.OpenField => new OpenField(),
            (int)AreaEnum.TranquilLake => new TranquilLake(),
            (int)AreaEnum.BlockedByLog => new BlockedByLog(),
            (int)AreaEnum.BlockedByStream => new BlockedByStream(),
            _ => new DefaultArea()
        };

        return returnArea;
    }
}