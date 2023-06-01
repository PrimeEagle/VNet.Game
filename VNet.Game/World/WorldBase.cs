namespace VNet.Game.World
{
    public abstract class WorldBase : IWorld
    {
        public HashSet<IRegion> Regions { get; set; }
    }
}