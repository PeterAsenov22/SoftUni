namespace Inferno_Infinity
{
    using System;
    using Inferno_Infinity.Interfaces;

    public abstract class Gem : IGem
    {
        protected Gem(string clarity)
        {
            this.Clarity = (GemClarity)Enum.Parse(typeof(GemClarity), clarity);
        }

        public int Strength { get; protected set; }

        public int Agility { get; protected set; }

        public int Vitality { get; protected set; }

        public GemClarity Clarity { get; private set; }

        protected int Modifier => (int)this.Clarity;
    }
}
