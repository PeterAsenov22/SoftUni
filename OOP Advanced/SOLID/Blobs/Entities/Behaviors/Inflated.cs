namespace _02.Blobs.Entities.Behaviors
{
    using Interfaces;

    public class Inflated : Behavior
    {
        private const int HealthGain = 50;
        private const int HealthLoss = 10;

        public override void Trigger(IBlob source)
        {
            source.Health += HealthGain;
            this.IsTriggered = true;
        }

        public override void ApplyRecurrentEffect(IBlob source)
        {
            source.Health -= HealthLoss;
        }
    }
}
