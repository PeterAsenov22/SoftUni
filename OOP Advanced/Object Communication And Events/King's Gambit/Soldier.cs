namespace King_s_Gambit
{
    using System;

    public delegate void SoldierDeathEventHandler(object sender, SoldierDeathEventArgs e);

    public abstract class Soldier
    {
        public event SoldierDeathEventHandler SoldierDeath;

        protected Soldier(string name, int hitsLeft)
        {
            this.Name = name;
            this.HitsLeft = hitsLeft;
        }

        public string Name { get; private set; }

        protected int HitsLeft { get; set; }

        public abstract void OnKingUnderAttack(object sender, EventArgs e);

        public void RespondToAttack()
        {
            this.HitsLeft--;
            if (this.HitsLeft==0)
            {
                OnSoldierDeath(new SoldierDeathEventArgs(this.Name,OnKingUnderAttack));
            }
        }

        protected void OnSoldierDeath(SoldierDeathEventArgs args)
        {
            if (this.SoldierDeath != null)
            {
                SoldierDeath(this, args);
            }
        }
    }
}
