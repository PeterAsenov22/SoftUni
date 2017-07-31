namespace Inferno_Infinity.Weapons
{
    using System;
    using System.Collections.Generic;

    [AttributeUsage(AttributeTargets.Class)]
    public class WeaponAttribute : Attribute
    {
        public WeaponAttribute(string author, int revision, string description, params string[] reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = reviewers;
        }

        public string Author { get; private set; }

        public int Revision { get; private set; }

        public string Description { get;private set; }

        public IList<string> Reviewers { get; private set; }
    }
}
