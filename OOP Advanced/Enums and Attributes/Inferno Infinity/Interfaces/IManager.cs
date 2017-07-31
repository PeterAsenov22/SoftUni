namespace Inferno_Infinity.Interfaces
{
    public interface IManager
    {
        void Create(string weaponType, string weaponName);

        void Add(string weaponName, int socketIndex, string gemType);

        void Remove(string weaponName, int socketIndex);

        string Print(string weaponName);
    }
}
