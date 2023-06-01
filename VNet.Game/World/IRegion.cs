using VNet.Game.Economy;
using VNet.Game.Government;
using VNet.Game.Society;

namespace VNet.Game.World
{
    public interface IRegion
    {
        public HashSet<IRegion> Regions { get; set; }
        public HashSet<IPopulationCenter> PopulationCenters { get; set; }
        public IEconomy Economy { get; set; }
        public HashSet<ISociety> Societies { get; set; }
        public IGovernment Government { get; set; }
    }
}