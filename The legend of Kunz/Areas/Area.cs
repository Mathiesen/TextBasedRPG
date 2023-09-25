﻿namespace The_legend_of_Kunz.Areas;

public abstract class Area
{
    public abstract void Description();
    public abstract void RandomEncounter();

    protected void TransitionTo(AreaEnum area, AreaEnum from)
    {
        AreaFactory.TransitionToArea(area, from);
    }
}