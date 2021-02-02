public class Person
{
    private string _name;

    public string Name
    {
        get 
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    // Classe interne private (ne peut pas être instancier hors de la classe Person)
    class InternalPersonPrivate
    {

    }

    // Classe interne public
    public class InternalPerson
    {

    }
}