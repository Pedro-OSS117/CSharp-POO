# Les Pointeurs

references :
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types

https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types
https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/operators/pointer-related-operators
https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/builtin-types/value-types

## I - Les Types Valeurs - Notion de copie

Les types valeur et les types référence sont les deux principales catégories de types C#. 
Une variable d’un type valeur contient une instance du type. 
Cela diffère d’une variable d’un type référence, qui contient une référence à une instance du type. 

https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/builtin-types/value-types

### Conséquences :
Par défaut, lors de l' assignation, en passant un argument à une méthode et en retournant un résultat de méthode, les valeurs des variables sont copiées. 
Dans le cas des variables de type valeur, les instances de type correspondantes sont copiées. L’exemple suivant illustre ce comportement :

```csharp

namespace ProjetCours
{
    public struct MyPoint
    {
        public int x;
        public int y;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    class Program
    {
        public static void Main()
        {
            /// I - Les Types Valeurs - Notion de copie
            Console.WriteLine("\n======== Les Types Valeurs - Notion de copie ========\n");

            // Creation d'une variable du type de la structure MyPoint (un type valeur).
            MyPoint p1 = new MyPoint(1, 2);

            // Creation d'une deuxième variable et initialisation avec la première (il y a copie de la première).
            MyPoint p2 = p1;

            // Modification d'une des valeurs de la deuxième variable.
            p2.y = 200;

            // Affichage des variables pour montrer que seulement p2 est modifée.
            Console.WriteLine($"Valeur {nameof(p1)} : {p1}");
            Console.WriteLine($"Valeur {nameof(p2)} : {p2}\n");

            // Utilisation d'une methode pour modifier p2.
            ModifyMyPointX(p2);

            // p2 n'a pas été modifié car lors de l'appel de la methode une copie a été faite.
            Console.WriteLine($"Valeur {nameof(p1)} : {p1}");
            Console.WriteLine($"Valeur {nameof(p2)} : {p2}");
		}
    }

	private static void ModifyMyPointX(MyPoint p)
	{
		p.x = 100;
		Console.WriteLine($"Point mutated in a method: {p}");
	}
}
```

## II - Les Pointeurs - Adresse Memoire

https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types
https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/operators/pointer-related-operators

![Representation de la Memoire](/00_-_Les_Pointeurs/Annexes/Representation_de_la_Memoire.jpg)

Une variable prend X octets en mémoire, son adresse est l'adresse du premier octet alloué en mémoire.
Pour accéder à l'adresse d'une variable on utilise les pointeurs.
Un pointeur est une variable qui contient une adresse qui pointe vers une variable en memoire.
Via un pointeur on peut accéder à la variable pointée.
Plusieurs pointeur peuvent pointé vers la même variable. (Notion de référence)

Declaration d'un pointeur : '*'
Pour declarer

```csharp
type* identifier;
```

Exemple avec des pointeurs de type int
```csharp
int* p1, p2, p3;   // Ok
int *p1, *p2, *p3;   // Invalid in C#
```

Exemple	Description
int* p :	p est un pointeur vers un entier.
int** p	: p est un pointeur vers un pointeur vers un entier.
int*[] p : 	p est un tableau unidimensionnel de pointeurs vers des entiers.
char* p :	p est un pointeur vers un caractère.
void* p :	p est un pointeur vers un type inconnu.

Operateurs utilisés pour les pointeurs : 

Opérateur/Instruction | Utilisation
------------ | -------------
*  | 	Exécute l'indirection de pointeur.
->  | 	Accède à un membre d'un struct via un pointeur.
[]  | 	Indexe un pointeur.
&  | 	Obtient l'adresse d'une variable.
++ et --  | 	Incrémente et décrémente les pointeurs.
+ et -  | 	Exécute des opérations arithmétiques sur les pointeurs.

Attention : Utiliser les pointeurs en CSharp n'est pas conseillé. C'est une notion très importante pour le C++ et le C.


## III - Le problèmes des pointeurs en CSharp - Garbage Collector
