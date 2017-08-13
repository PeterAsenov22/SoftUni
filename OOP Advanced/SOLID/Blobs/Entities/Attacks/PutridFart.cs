namespace _02.Blobs.Entities.Attacks
{
    using Interfaces;

    public class PutridFart : Attack
    {
        public override void Execute(IBlob attacker, IBlob target)
        {
            target.Health -= attacker.Damage;
        }
    }
}