namespace VNet.Game.Society
{
    public abstract class CultureBase : ICulture
    {
        public IReligion Religion { get; set; }
        public ILanguage Language { get; set; }
    }
}