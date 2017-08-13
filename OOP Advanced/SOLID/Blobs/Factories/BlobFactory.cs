namespace _02.Blobs.Factories
{
    using Entities;
    using Interfaces;

    public class BlobFactory
    {
        public static IBlob CreateNewBlob(string[] parameters)
        {
            string name = parameters[0];
            int health = int.Parse(parameters[1]);
            int damage = int.Parse(parameters[2]);
            IBehavior behavior = BehaviorFactory.CreateBehavior(parameters[3]);
            IAttack attack = AttackFactory.CreateAttack(parameters[4]);

            return new Blob(name,health,damage,behavior,attack);
        }
    }
}
