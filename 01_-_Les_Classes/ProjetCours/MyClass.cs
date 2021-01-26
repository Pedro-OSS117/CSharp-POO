using System;

namespace ProjetCours
{
    public class MyClass
    {
        // -------- Ici on déclare les propriétés membres de la classe
        // Nomenclature => '_' devant le nom de la propriété.
        private string _propsMember;
        // -------- Ici on déclare les propriétés membres de la classe

        // Accesseur
        public string PropsMember
        {
            get { return _propsMember; }
            set { _propsMember = value; }
        }

        // Constructeur par defaut surchargé
        public MyClass()
        {
            Console.WriteLine("Bonjour, je suis une instance de my class et je viens d'être créée via le constructeur par defaut");
        }

        // Constructeur avec paramètres et intialisation de propriétés
        public MyClass(string propsValue)
        {
            _propsMember = propsValue;
            Console.WriteLine("Bonjour, je suis une instance de my class et je viens d'être créé via un constructeur");
        }

        // [Accessibilité] [Type retour] [Identifiant] [Parametres]
        public void MyMethod(int param1, float param2)
        {
            // Do Something
        }
    }
}