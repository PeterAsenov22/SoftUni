namespace Military_Elite.Soldiers
{
    using System.Collections.Generic;
    using System.Text;

    public class LeutenantGeneral:Soldier,IPrivate, ILeutenantGeneral
    {
        public List<Private> Privates { get; private set; }
        
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<Private> privates)
            :base(id,firstName,lastName,salary)
        {
            this.Privates = privates;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var _private in this.Privates)
            {
                sb.AppendLine($"  {_private}");
            }

            return sb.ToString().Trim();
        }   
    }
}
