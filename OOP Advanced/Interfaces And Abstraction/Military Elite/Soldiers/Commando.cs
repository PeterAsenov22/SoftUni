namespace Military_Elite.Soldiers
{
    using System.Collections.Generic;
    using System.Text;
    using Military_Elite.Interfaces;

    public class Commando:SpecialisedSoldier,ICommando
    {
        public List<Mission> Missions { get; }

        public Commando(string id, string firstName, string lastName, double salary, string corps, List<Mission> missions) : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            foreach (var mission in this.Missions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
