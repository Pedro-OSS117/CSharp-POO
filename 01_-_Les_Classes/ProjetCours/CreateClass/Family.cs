using System;

namespace CreateClass
{
    public class Family
    {
        private Person[] _members;

        public void AddMember(Person newMember)
        {
            if (_members != null)
            {
                Person[] members = new Person[_members.Length + 1];
                for (int i = 0; i < _members.Length; i++)
                {
                    members[i] = _members[i];
                }
                members[_members.Length] = newMember;
                _members = members;
            }
            else
            {
                _members = new Person[] {newMember};
            }
        }

        public void DisplayAllMembers()
        {
            Console.WriteLine("Our Familiy is composed by : ");
            foreach (Person p in _members)
            {
                p.DisplayIdentity();
            }
        }
    }
}