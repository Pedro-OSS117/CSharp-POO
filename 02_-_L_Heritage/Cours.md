# L'Heritage - Inheritance

References : 

- https://docs.microsoft.com/fr-fr/dotnet/csharp/tutorials/inheritance
- https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/inheritance
- https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance

1 - Qu'est ce que l'Heritage en POO

L’héritage permet de construire une classe B à partir d’une classe existante A. 
Il s’agit d’une sorte d’héritage biologique. La classe B va ainsi hériter des variables, des méthodes, bref de tous les membres de A puis, 
on va ajouter des éléments supplémentaires propres à la classe B.

Si B hérite de A, on dit que B est une classe fille, une sous-classe, une classe enfant ou encore une classe dérivée de A.
A l’inverse, A se nomme la classe mère, la classe de base, la classe parent ou encore la super classe de B.

On peut examiner l’héritage de deux façons différentes :

- Dans la vision par spécialisation/redéfinition, la classe B est vue comme un cas particulier de la classe A. Par exemple, un 4x4 est un cas particulier d’une Voiture. Dans cette vision, l’ensemble des Voitures est l’ensemble englobant et les 4x4 représentent un sous-ensemble des Voitures.

- Dans la vision par extension, la classe B est vue comme une version étendue de la classe A. Par exemple, un 4x4 est une voiture disposant de 2 roues motrices supplémentaires. Du point de vue des fonctionnalités, la classe 4x4 englobe les fonctionnalités de la classe Voiture, la classe Voiture a moins de paramètres internes que la classe 4x4.

../_images/demo.svg

Un héritage entre plusieurs classes donne naissance à une hiérarchie dans laquelle une classe peut avoir :
- des ancêtres : sa classe mère, la classe mère de sa classe mère, et ainsi de suite…
- des descendants : ses classes filles, les classes filles de ses classes filles, et ainsi de suite…

Conception de programme :
L’héritage est une approche puissante pour la structuration des programmes et la réutilisation du code. 
Comme toute technique de réutilisation, elle facilite la maintenance et améliore la productivité. 
De plus, la structuration du programme induite par l’utilisation du mécanisme d’héritage facilite grandement la compréhension. 


2 - Heritage - Les Mots Clefs - ':', protected, override, virtual, abstarct

3 - Heritage Implicite - Classe Object


4 - Exemples d'heritage - Concept et classe fille

Animal ->
Vehicle ->
Shape ->
Account ->
