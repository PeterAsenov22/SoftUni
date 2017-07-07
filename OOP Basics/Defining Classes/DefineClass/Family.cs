using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class Family
    {
        public List<Person> familyMembers;

        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public List<Person> GetOldestMember()
        {
            return this.familyMembers.Where(x=>x.age>30).ToList();
        }
    }
}
