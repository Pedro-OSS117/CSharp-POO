# Les Pointeurs

## I - Les Types Valeurs - Notion de copie

Les types valeur et les types référence sont les deux principales catégories de types C#. 
Une variable d’un type valeur contient une instance du type. 
Cela diffère d’une variable d’un type référence, qui contient une référence à une instance du type. 

### Conséquences :
Par défaut, lors de l' assignation, en passant un argument à une méthode et en retournant un résultat de méthode, les valeurs des variables sont copiées. 
Dans le cas des variables de type valeur, les instances de type correspondantes sont copiées. L’exemple suivant illustre ce comportement :

'''CSharp
using System;

public struct MutablePoint
{
    public int X;
    public int Y;

    public MutablePoint(int x, int y) => (X, Y) = (x, y);

    public override string ToString() => $"({X}, {Y})";
}

public class Program
{
    public static void Main()
    {
        var p1 = new MutablePoint(1, 2);
        var p2 = p1;
        p2.Y = 200;
        Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
        Console.WriteLine($"{nameof(p2)}: {p2}");

        MutateAndDisplay(p2);
        Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
    }

    private static void MutateAndDisplay(MutablePoint p)
    {
        p.X = 100;
        Console.WriteLine($"Point mutated in a method: {p}");
    }
}
'''

## II - Les Pointeurs - Adresse Memoire

![Representation de la Memoire](/00_-_Les_Pointeurs/Annexes/Representation_de_la_Memoire.jpg)

## III - Le problèmes des pointeurs en CSharp - Garbage Collector
