namespace King_s_Gambit
{
    using System;

    public class King
    {
        public event EventHandler UnderAttack;

        public King(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void RespondToAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            OnUnderAttack(new EventArgs());
        }

        protected void OnUnderAttack(EventArgs e)
        {
            if (UnderAttack != null)
            {
                UnderAttack(this, e);
            }
        }

        public void OnSoldierDeath(object sender, SoldierDeathEventArgs e)
        {
            this.UnderAttack -= e.OnKingUnderAttack;
        }
    }
}
