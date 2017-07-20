namespace Military_Elite
{
    using System.Text;
    using Military_Elite.Interfaces;
    using Military_Elite.Soldiers;

    public abstract class SpecialisedSoldier:Soldier, ISpecialisedSoldier
    {
        public string Corps { get; private set; }

        protected SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps)
            :base(id,firstName,lastName,salary)
        {
            this.Corps = corps;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");

            return sb.ToString().Trim();
        }
    }
}
