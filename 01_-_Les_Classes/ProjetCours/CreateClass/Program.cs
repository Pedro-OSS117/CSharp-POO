using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bob", "Morane", 16);
            p1.DisplayIdentity();

            Person p2 = new Person("Alice", "Country", 18);

            p2.DisplayIdentity();

            Family family = new Family();
            family.AddMember(p1);
            family.AddMember(p2);
            family.DisplayAllMembers();
        }
    }
}
