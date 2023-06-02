namespace VNet.Game.Society
{
    public interface ICulture
    {
        public IReligion Religion { get; set; }
        public ILanguage Language { get; set; }
    }
}