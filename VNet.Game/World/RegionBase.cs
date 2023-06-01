using VNet.AI.Behavior.Agents;
using VNet.Game.Economy;
using VNet.Game.Government;
using VNet.Game.Society;

namespace VNet.Game.World
{
    public abstract class RegionBase : IRegion
    {
        public HashSet<IRegion> Regions { get; set; }
        public HashSet<IPopulationCenter> PopulationCenters { get; set; }
        public IEconomy Economy { get; set; }
        public HashSet<ISociety> Societies { get; set; }
        public IGovernment Government { get; set; }
        public HashSet<IAgent> Agents { get; set; }
    }
}