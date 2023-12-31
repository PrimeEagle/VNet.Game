﻿using VNet.AI.Behavior.Agents;
using VNet.Game.Economy;
using VNet.Game.Society;

namespace VNet.Game.World
{
    public abstract class PopulationCenterBase : IPopulationCenter
    {
        public IEconomy Economy { get; set; }
        public ISociety Society { get; set; }
        public HashSet<IAgent> Agents { get; set; }
    }
}