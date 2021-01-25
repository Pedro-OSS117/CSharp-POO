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
On va utiliser la notion de référence sans avoir besoin des pointeurs.

On a vu que pour pouvoir faire des références lorsqu'on utilise des structures il faut des pointeurs.
Or en CSharp la memoire est gérée par le Garbage Collector et il ne gère pas les Pointeurs (unsafe).
D'où le fait d'utiliser au maximum les Classes pour organiser nos programmes.
Par contre les structures pourront être utilisées pour des concepts d'objet simple comme par exemple le 'Vector3'.

## II - Les Classes - Notion de Concept et d'Instance
https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/
https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/classes

### 1 - Concept d'une Classe - Création d'une Classe == Creation d'une type 



### 2 - Instance d'une Classe -  Type Référence - Null

Lorsqu'on utilise le mot clef 'new' on créé une instance du type de la class.

Un type défini comme class est un type référence. 
Au moment de l’exécution, quand vous déclarez une variable de type référence, celle-ci contient la valeur Null 
tant que vous n’avez pas explicitement créé une instance de la classe à l’aide de l’opérateur new, 
ou que vous ne lui avez pas assigné un objet existant d’un type compatible, comme indiqué dans l’exemple suivant :

```csharp
//Declaring an object of type MyClass.
MyClass mc = new MyClass();

//Declaring another object of the same type, assigning it the value of the first object.
MyClass mc2 = mc;
```

Il est possible d'avoir plusieurs référence vers une même instance.
Si dans une portée il n'y plus de référence alors l'instance sera detruite par le garbage collector, sinon elle reste en mémoire.

## III - Créér une Classe - Constructeur et Propriétes Membres

### 1 - Declaration de la Class == Nouveau Type 

```csharp
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

#### Classe Interne

Il est tout de même possible de créer plusieurs classe dans un même fichier.
Il est possible aussi de créer une classe dans une classe.
Elle sera dite interne à la Classe et ne pourrat être instancier qu'au travers de la classe qui la contient.

```csharp
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

### 2 - Propriétés Membres

Lorsqu'on défini une classe en général on lui ajoute des propriétés.
Convention : Ces propriétés dites membres sont déclarées juste en dessous du nom de la classe.
Nomenclature : '_' devant le nom de la propriété, celà permet de savoir que c'est une propriété quand elle est utilisée ailleurs dans le code.

Les propriétés sont des données définissants la class.
Lorsqu'on décide d'ajouter des propriétés à une classe il faut suivre le principe d'encapsulation.
    
```csharp
public class MyClass
{
    // -------- Ici on déclare les propriétés membres de la classe
    // Nomenclature => '_' devant le nom de la propriété.
    private string _propsMember;
    
    // -------- Ici on déclare les propriétés membres de la classe
}
```

### 3 - Constructeurs

Lorsqu'on utilise le mot clef 'new' pour instancier une classe, on appelle en fait un Constructeur.

#### Constructeur par defaut
Il y a toujours un constructeur par defaut pour une classe même si aucun constructeur n'est déclaré.
On peut donc créer une instance d'une classe avec el mot clef 'new' même si aucun constructeur n'est déclaré.
L'instance de la classe aura alors toutes ses propriétés intialisées par des valeurs par defaut.
On peut déclarer et implementer le constructeur par defaut pour qu'à la création un conmportement particulié soit executer.
Le constructeur par defaut est celui sans paramètres.
```csharp
public class MyClass
{
    private string _propsMember;
    
    // Constructeur par defaut surchargé
    public MyClass()
    {
        Console.WriteLine("Bonjour, je suis une instance de my class et je viens d'être créée via le constructeur par defaut");
    }
}
```

#### Constructeur
Un constructeur a comme signature :

```csharp
public class MyClass
{
    private string _propsMember;

    // Constructeur avec paramètres et intialisation de propriétés
    public MyClass(string propsValue)
    {
        _propsMember = propsValue;
        Console.WriteLine("Bonjour, je suis une instance de my class et je viens d'être créé via un constructeur");
    }
}
```

### 4 - Methodes

### 5 - Variables et Fonctions static d'une classe
Accessible à l'éxécutioin dès que le type est chargé.
Pas besoin d'instance pour être utilisées
On utilise le nom de la classe pour les appeler.

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
