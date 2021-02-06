# L'Heritage - Inheritance

References : 

- https://docs.microsoft.com/fr-fr/dotnet/csharp/tutorials/inheritance
- https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/inheritance
- https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance

## 1 - Qu'est ce que l'Heritage en POO

L’héritage permet de construire une classe B à partir d’une classe existante A. 
Il s’agit d’une sorte d’héritage biologique. La classe B va ainsi hériter des variables, des méthodes, bref de tous les membres de A puis, 
on va ajouter des éléments supplémentaires propres à la classe B.

Si B hérite de A, on dit que B est une __classe fille__, une __sous-classe__, une __classe enfant__ ou encore une __classe dérivée__ de A.
A l’inverse, A se nomme la __classe mère__, la __classe de base__, la __classe parent__ ou encore la __super classe__ de B.

On peut examiner l’héritage de deux façons différentes :

- Dans la vision par spécialisation/redéfinition, la classe B est vue comme un cas particulier de la classe A. Par exemple, un 4x4 est un cas particulier d’une Voiture. Dans cette vision, l’ensemble des Voitures est l’ensemble englobant et les 4x4 représentent un sous-ensemble des Voitures.

- Dans la vision par extension, la classe B est vue comme une version étendue de la classe A. Par exemple, un 4x4 est une voiture disposant de 2 roues motrices supplémentaires. Du point de vue des fonctionnalités, la classe 4x4 englobe les fonctionnalités de la classe Voiture, la classe Voiture a moins de paramètres internes que la classe 4x4.

![Exemple d'heritage - Les Vehicules](/02_-_L_Heritage/Annexes/Heritage_Vehicule.jpg)

Un héritage entre plusieurs classes donne naissance à une hiérarchie dans laquelle une classe peut avoir :
- des ancêtres : sa classe mère, la classe mère de sa classe mère, et ainsi de suite…
- des descendants : ses classes filles, les classes filles de ses classes filles, et ainsi de suite…

### Heritage == Conception de programme :
L’héritage est une approche puissante pour la structuration des programmes et la réutilisation du code. 
Comme toute technique de réutilisation, elle facilite la maintenance et améliore la productivité. 
De plus, la structuration du programme induite par l’utilisation du mécanisme d’héritage facilite grandement la compréhension. 

## 2 - Heritage - Les Mots Clefs - ':', protected, override, abstract, virtual

### ':'

L'operateur ':' permet de definir quelle est la classe mère.
Si B hérite de A alors on ecrit __public class B : A__

```csharp
public class B : A
{

}
```

### protected

Le mot clefs __protected__ permet de donner accès à une propriété ou methode aux classes filles.
Une propriété ou methode __protected__ n'est pas accessible à l'exterieur de la classe.

```csharp
public class A
{
    private int myPropsAPrivate;
    protected int myPropsAProtected;
}

public class B : A
{
    public void MyBMethod()
    {
        // Pas d'accès à myPropsAPrivate car private.
        // myPropsAPrivate = 10; // ERROR
        // Mais accès à la prop myPropsAProtected car protected
        myPropsAProtected = 10;
    }
}
```

## 3 - Heritage Implicite - Classe Object

- https://docs.microsoft.com/fr-fr/dotnet/api/system.object?view=net-5.0

L’héritage implicite à partir de la classe Object rend ces méthodes disponibles pour la classe MyClasse :

```csharp
public class MyClass
{
    public int id = 0;

    public override string ToString()
    {
        return "Override de la fonction ToString pour la classe MyClass";
    }

    public override bool Equals(object obj)
    {
        // "Override de la fonction Equals pour la classe MyClass"
        MyClass myClassVar = obj as MyClass;
        if(myClassVar == null)
        {
            return false;
        }
        // Les instances sont egales si leur id sont egaux.
        return id == myClassVar.id;
    }
}
```

La méthode public ToString, qui convertit un objet MyClasse en sa représentation de chaîne, retourne le nom de type complet. Dans ce cas, la méthode ToString retourne la chaîne « MyClasse ».

Voici trois méthodes de test d’égalité de deux objets :

-  la méthode public instance Equals(Object), la méthode public static Equals(Object, Object) et la méthode public static ReferenceEquals(Object, Object). Par défaut, ces méthodes testent l’égalité des références. Autrement dit, pour être égales, deux variables d’objet doivent faire référence au même objet.

- La méthode public GetHashCode, qui calcule une valeur qui permet à une instance du type d’être utilisée dans des collections hachées.

- La méthode GetType publique qui retourne un objet Type qui représente le type MyClasse.

![Heritage Implicite - Classe Object](/02_-_L_Heritage/Annexes/ClasseObject.jpg)

### 4 - Exemples d'heritage - Concept et classe fille

Animal ->
Vehicle ->
Shape ->
Account ->
