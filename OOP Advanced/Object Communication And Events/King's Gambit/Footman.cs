namespace King_s_Gambit
{
    using System;

    public class Footman : Soldier
    {
        private const int FootmanHits = 2;

        public Footman(string name) : base(name,FootmanHits)
        {
        }

        public override void OnKingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
