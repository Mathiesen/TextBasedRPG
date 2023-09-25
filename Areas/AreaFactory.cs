using The_legend_of_Kunz.Areas;
using The_legend_of_Kunz.Areas.Implementation;

namespace Areas;

public static class AreaFactory
{
    public static Area TransitionToArea(AreaEnum to, AreaEnum from = AreaEnum.Undefined)
    {
        Area returnArea = to switch
        {
            AreaEnum.DarkForrest => new DarkForrest(),
            AreaEnum.Village => new Village(),
            AreaEnum.Ruin => new Ruin(),
            AreaEnum.BanditCamp => new BanditCamp(),
            AreaEnum.MysticalCave =>  new MysticalCave(),
            AreaEnum.DragonLair => new DragonLair(from),
            AreaEnum.OpenField => new OpenField(),
            AreaEnum.TranquilLake => new TranquilLake(),
            AreaEnum.BlockedByLog => new BlockedByLog(),
            AreaEnum.BlockedByStream => new BlockedByStream(),
            _ => new DefaultArea()
        };

        return returnArea;
    }
    
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