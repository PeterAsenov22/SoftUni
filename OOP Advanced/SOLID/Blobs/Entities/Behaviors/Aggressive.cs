namespace _02.Blobs.Entities.Behaviors
{
    using Interfaces;

    public class Aggressive : Behavior
    {
        private const int AggressiveDamageMultiplier = 2;
        private const int AggressiveDamageDecrementer = 5;

        private int sourceInitialDamage;

        public override void Trigger(IBlob source)
        {
            this.sourceInitialDamage = source.Damage;
            this.IsTriggered = true;
            this.ApplyTriggerEffect(source);
        }

        public override void ApplyRecurrentEffect(IBlob source)
        {
            source.Damage -= AggressiveDamageDecrementer;

            if (source.Damage <= this.sourceInitialDamage)
            {
                source.Damage = this.sourceInitialDamage;
            }
        }

        private void ApplyTriggerEffect(IBlob source)
        {
            source.Damage = source.Damage * AggressiveDamageMultiplier;
        }
    }
}