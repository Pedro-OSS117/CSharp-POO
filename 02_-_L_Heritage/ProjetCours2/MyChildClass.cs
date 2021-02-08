using System;

namespace ProjetCours2
{
    public class MyChildClass : MyClass
    {        
        private void MyMethodPrivate()
        {
            // Accès dans les filles
            _myVarProtected = 1;

            // Accès partout
            myVarPublic = 0;

            // Pas d'accès
            //myVarPrivate = 1;

            MyMethodMyClassPublic();
            MyMethodMyClassProtected();
            //MyMethodMyClassPrivate();
        }

        public override void MyMethodMother()
        {
            Console.WriteLine("Coucou je suis la fille !");
        }
    }
}