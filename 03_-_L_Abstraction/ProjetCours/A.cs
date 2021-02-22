using System;

namespace ProjetCours
{
    public abstract class A
    {
        public int props;
        private int _pros2;
        protected int _props3;

        protected void Coucou()
        {
            Console.WriteLine("Coucou");
        }

        protected abstract void MyAbstractMethod();

        protected virtual void MyVirtualMethod()
        {
            
        }
        
    }
}