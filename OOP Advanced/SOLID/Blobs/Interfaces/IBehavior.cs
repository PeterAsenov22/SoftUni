namespace _02.Blobs.Interfaces
{
    public interface IBehavior
    {
        bool IsTriggered { get; set; }

        void Trigger(IBlob source);

        void ApplyRecurrentEffect(IBlob source);
    }
}