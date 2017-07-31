namespace Inferno_Infinity.Interfaces
{
    public interface IGem
    {
        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }

        GemClarity Clarity { get; }
    }
}
