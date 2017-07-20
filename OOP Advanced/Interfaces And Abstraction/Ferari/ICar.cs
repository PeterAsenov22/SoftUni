namespace Ferari
{
    public interface ICar
    {
        string Driver { get; }

        string Model { get; }

        string Brakes();

        string GasPedal();
    }
}
