using System;

namespace ProjetCours
{
    public class B : A
    {
        protected override void MyAbstractMethod()
        {
            Console.WriteLine("Coucou");
        }
    }
}