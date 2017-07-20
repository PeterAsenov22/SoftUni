﻿namespace Military_Elite.Soldiers
{
    using System.Text;
    using Military_Elite.Interfaces;

    public class Spy:Soldier,ISpy
    {
        public int CodeNumber { get; }

        public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.ID}");
            sb.AppendLine($"Code Number: {this.CodeNumber}");

            return sb.ToString().Trim();
        }
    }
}
