using System;

public class Person
{
    private string _firstName = "NoName";
    private string _lastName = "NoName";
    private int _age = 0;

    // Constructeur par defaut - En le definissant on le surcharge
    private Person()
    {
    }

    // Constructeur qui permet de créer une personne qui vient de naitre
    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    // Constructeur qui permet de créer une personne d'une certain age
    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        // On peut acceder au methode d'accessibilité private
        // n'importe où dans la portée de la classe
        MethodPrivate();
    }

    private void MethodPrivate()
    {
        DisplayIdentity();
    }

    public void DisplayIdentity()
    {
        Console.WriteLine($"My name is {_firstName} {_lastName} and my age is {_age}");
    }

    public static void DisplayIdentityStatic(Person personne)
    {
        personne.DisplayIdentity();
    }
}