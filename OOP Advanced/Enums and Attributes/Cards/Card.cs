namespace Cards
{
    using System;

    public class Card:IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.Rank = (Ranks)Enum.Parse(typeof(Ranks),rank);
            this.Suit = (Suits)Enum.Parse(typeof(Suits),suit);
        }

        public Ranks Rank { get; private set; }

        public Suits Suit { get; private set; }

        public int Power => (int) this.Rank + (int) this.Suit;

        public int CompareTo(Card other)
        {
            return other.Power.CompareTo(this.Power);
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}
