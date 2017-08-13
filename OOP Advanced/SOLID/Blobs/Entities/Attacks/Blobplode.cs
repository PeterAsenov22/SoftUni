namespace _02.Blobs.Entities.Attacks
{
    using Interfaces;

    public class Blobplode : Attack
    {
        private const int DamageMultiplier = 2;
        private const int MinimumHealth = 1;

        public override void Execute(IBlob attacker, IBlob target)
        {
            int healthLoss = attacker.Health / 2;
            if (healthLoss < MinimumHealth)
            {
                attacker.Health = MinimumHealth;
            }
            else
            {
                attacker.Health -= healthLoss;
            }

            target.Health -= attacker.Damage * DamageMultiplier;
        }
    }
}
