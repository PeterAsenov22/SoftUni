namespace King_s_Gambit
{
    using System;

    public class SoldierDeathEventArgs : EventArgs
    {
        public SoldierDeathEventArgs(string name, EventHandler onKingUnderAttack)
        {
            this.Name = name;
            this.OnKingUnderAttack = onKingUnderAttack;
        }

        public string Name { get; private set; }

        public EventHandler OnKingUnderAttack { get; private set; }
    }
}
