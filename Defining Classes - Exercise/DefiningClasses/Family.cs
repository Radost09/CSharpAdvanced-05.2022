using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }
        public List<Person> FamilyMembers { get; set; }
        public void AddMember (Person member)
        {
            this.FamilyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            int maxAge = this.FamilyMembers.Max(member => member.Age);
            return this.FamilyMembers.First(member => member.Age == maxAge);
        }

    }
}
