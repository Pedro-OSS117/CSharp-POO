using System;

namespace PendantCours
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dès la declaration il y a création en memoire => Type Valeur
            int i;
            MyStruct varMyStruct1;
            varMyStruct1.index = 1;

            // Ici la variable est déjà créé donc appeler le constructeur intialise les propriétés.
            MyStruct varMyStruct2 = new MyStruct();  
            varMyStruct1 = varMyStruct2;
            varMyStruct1.index = 10;
            varMyStruct2.index = 3;

            ModifMyStruct(varMyStruct1);

            Console.WriteLine($"{nameof(varMyStruct1)} : {varMyStruct1.index} et {nameof(varMyStruct2)} : {varMyStruct2.index}");

            // Dès la declaration il n'y a pas création en mémoire => Type Réfécence
            // La valeur de la référence est 'null'.
            MyClass varMyClass1 = null;

            // Il faut utiliser le new pour creer un objet de la classe en memoire.
            MyClass varMyClass2 = new MyClass();
            // Lorsqu'on assigne une variable de type reference avec une autre variable,
            // on fait pointer la variable assignée sur le même objet.
            varMyClass1 = varMyClass2;
            varMyClass1.index = 1;
            varMyClass2.index = 5;
            
            ModifMyClass(varMyClass1);
            Console.WriteLine($"{nameof(varMyClass1)} : {varMyClass1.index} et {nameof(varMyClass2)} : {varMyClass2.index}");
            
        }

        static void ModifMyClass(MyClass myClass)
        {
            myClass.index = 42;
        }

        static void ModifMyStruct(MyStruct myStruct)
        {
            myStruct.index = 42;
        }
    }

    struct MyStruct
    {
        public int index;
    }

    class MyClass
    {
        public int index;
    }
}
