# Les Classes

References : 

- https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/

## I - Des Pointeurs aux Classes

La notion de référence est devenue indispensable pour pouvoir faire des programmes de plus en plus complexes.
Les besoins des programmeurs :
- Programme bien conçus pour une bonee compréhension des concepts présents dans le programme
- Programme facile à maintenir et à etandre 
- Programme performant, autant lors execution qu'au niveau de la gestion de la memoire.

Lorsqu'on créé une variable de type Classes, cette variable sera obligatoirement une reference vers l'instance créée.
Les Classes sont de Type Réference contrairement aux Structures qui sont de Type Valeur.

### Classes VS Structures
La notion de Classe va permettre de mieux structurer nos programmes en "Concept".
Et aussi utiliser la notion de référence sans avoir besoin des pointeurs.
On a vu que pour pouvoir faire des références lorsqu'on utilise des structures il faut des pointeurs.
Or en CSharp la memoire est gérée par le Garbage Collector et il ne gère pas les Pointeurs.
D'où le fait d'utiliser exclusivement les Classes pour organiser nos programmes.
Par contre les structures pourront être utilisées pour des concepts d'objet simple comme par exemple le 'Vector3'.

## II - Les Classes - Notion de Concept et d'Instance
https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/
https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/classes

### Création d'une Classe == Creation d'une type 



### Instance d'une classe -  Type Référence - Null

Lorsqu'on utilise le mot clef 'new' on créé une instance du type de la class.

Un type défini comme class est un type référence. 
Au moment de l’exécution, quand vous déclarez une variable de type référence, celle-ci contient la valeur Null 
tant que vous n’avez pas explicitement créé une instance de la classe à l’aide de l’opérateur new, 
ou que vous ne lui avez pas assigné un objet existant d’un type compatible, comme indiqué dans l’exemple suivant :

```
//Declaring an object of type MyClass.
MyClass mc = new MyClass();

//Declaring another object of the same type, assigning it the value of the first object.
MyClass mc2 = mc;
```

Il est possible d'avoir plusieurs référence vers une même instance.
Si dans une portée il n'y plus de référence alors l'instance sera detruite par le garbage collector, sinon elle reste en mémoire.

## III - Créér une Classe - Constructeur et Propriétes Membres

### Declaration de la Class == Nouveau Type 

```
// Dans un fichier Person.cs
// Declaration du nouveau type Person
class Person
{
	
}

// Dans 
public class Program
{
	static void Main(string[] args)
	{
		// Creation d'une instance de la classe (Instatiation)
		Person person = new Person();
	}
}
```

Tous ce qui est déclaré dans la portée de la classe Person, sera accessible uniquement via le type Person.
En général on a : un fichier .cs == 1 class.

### Classe Interne

Il est tout de même possible de créer plusieurs classe dans un même fichier.
Il est possible aussi de créer une classe dans une classe.
Elle sera dite interne à la Classe et ne pourrat être instancier qu'au travers de la classe qui la contient.

```
public class Program
{
	static void Main(string[] args)
	{
	}
}

public class Person
{
	// Classe interne private (ne peut pas être instancier hors de la classe Person)
	class InternalPersonPrivate
	{

	}
	
	// Classe interne public
	public class InternalPerson
	{

	}
}
```

### Propriétés Membres

### Constructeurs

Lorsqu'on utilise le mot clef 'new' pour instancier une classe, on appelle en fait un Constructeur.
###


### Methodes

### Variables et Fonctions static d'une classe

## IV - Encapsulation et Accesseurs
https://docs.microsoft.com/fr-fr/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming
https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming

### private, public
L’encapsulation est parfois considérée comme le premier pilier ou principe de la programmation orientée objet. 
D'après le principe d'encapsulation, une classe ou un struct peut spécifier le degré d'accessibilité de chacun 
de ses membres au code situé en dehors de la classe ou du struct. Les méthodes et variables qui ne sont pas 
destinées à être utilisées d’en dehors de la classe ou de l’assembly peuvent être masquées afin de limiter 
le risque d’erreurs ou de code malveillant exploitant une faille de sécurité.

### Accesseurs