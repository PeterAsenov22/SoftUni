namespace Military_Elite.Soldiers
{
    using System.Collections.Generic;
    using System.Text;
    using Military_Elite.Interfaces;

    public class Engineer:SpecialisedSoldier,IEngineer
    {
        public List<Repair> Repairs { get; }

        public Engineer(string id, string firstName, string lastName, double salary, string corps, List<Repair> repairs)
            :base(id,firstName,lastName,salary,corps)
        {
            this.Repairs = repairs;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var repair in this.Repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().Trim();
        }   
    }
}
