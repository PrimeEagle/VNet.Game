﻿namespace VNet.Game.World
{
    public interface IWorld
    {
        public HashSet<IRegion> Regions { get; set; }
    }
}