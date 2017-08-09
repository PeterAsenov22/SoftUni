namespace Skeleton.FakeClasses
{
    using Skeleton.Interfaces;

    public class FakeWeapon : IWeapon
    {
        public int AttackPoints => 0;

        public int DurabilityPoints => 0;

        public void Attack(ITarget target)
        {
            
        }
    }
}
