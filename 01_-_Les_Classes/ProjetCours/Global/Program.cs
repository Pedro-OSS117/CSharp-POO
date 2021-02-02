using System;

namespace ProjetCours
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration d'une reference de type MyClass
            // Creation d'une instance de la classe et assignation de la reference à cette instance.
            MyClass refMyClassInstance = new MyClass();

            // Declaration d'une reference, sans assignation donc la ref ne pointe nulle part
            MyClass ref2MyClassInstance;

            // Assignation de la reference à l'instance créée précédemment => 2 refs sur 1 instance
            ref2MyClassInstance = refMyClassInstance;

            // Utilisation d'accesseur
            refMyClassInstance.PropsMember = "NewValue";

            // Utilisation des accesseurs
            Person p = new Person();
            p.Name = "coucou";
            string texte = p.Name;
        }
    }
}
