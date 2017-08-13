namespace King_s_Gambit
{
    using System;

    public class RoyalGuard : Soldier
    {
        private const int RoyalGuardHits = 3;

        public RoyalGuard(string name) : base(name,RoyalGuardHits)
        {
        }

        public override void OnKingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
