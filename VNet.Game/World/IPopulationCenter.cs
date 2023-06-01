using VNet.Game.Economy;
using VNet.Game.Society;

namespace VNet.Game.World
{
    public interface IPopulationCenter
    {
        public IEconomy Economy { get; set; }
        public ISociety Society { get; set; }
    }
}