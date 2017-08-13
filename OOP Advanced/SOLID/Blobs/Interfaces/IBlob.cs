namespace _02.Blobs.Interfaces
{
    public interface IBlob
    {
        string Name { get; }

        IBehavior Behavior { get; }

        IAttack Attack { get; }

        int Damage { get; set; }

        int Health { get; set; }

        void AttackBlob(IBlob blobToAttack);

        void Behave();
    }
}
