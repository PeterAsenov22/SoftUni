namespace _02.Blobs.Entities.Behaviors
{
    using Interfaces;

    public abstract class Behavior : IBehavior
    {
        protected Behavior()
        {
            this.IsTriggered = false;
        }

        public bool IsTriggered { get; set; }

        public abstract void Trigger(IBlob source);

        public abstract void ApplyRecurrentEffect(IBlob source);
    }
}