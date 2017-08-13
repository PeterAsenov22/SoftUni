namespace _02.Blobs.Entities
{
    using Interfaces;

    public class Blob : IBlob
    {
        private int health;
        private int initialHealth;

        public Blob(string name, int health, int damage, IBehavior behavior, IAttack attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Behavior = behavior;
            this.Attack = attack;
            this.initialHealth = health;
        }

        public string Name { get; private set; }

        public IBehavior Behavior { get; private set; }

        public IAttack Attack { get; private set; }

        public int Damage { get; set; }

        public int Health
        {
            get { return this.health; }
            set
            {
                this.health = value;

                if (this.health < 0)
                {
                    this.health = 0;
                }

                if (this.health <= this.initialHealth / 2 && !this.Behavior.IsTriggered)
                {
                    this.Behavior.Trigger(this);
                }
            }
        }

        public void AttackBlob(IBlob blobToAttack)
        {
            if (this.Health > 0 && blobToAttack.Health > 0)
            {
                this.Attack.Execute(this, blobToAttack);
            }
        }

        public void Behave()
        {
            if (this.Behavior.IsTriggered)
            {
                this.Behavior.ApplyRecurrentEffect(this);
            }
        }

        public override string ToString()
        {
            if (this.Health == 0)
            {
                return $"IBlob {this.Name} KILLED";
            }

            return $"IBlob {this.Name}: {this.Health} HP, {this.Damage} Damage";
        }
    }
}