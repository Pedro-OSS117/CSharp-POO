using System;

/*
1 - Creer une classe Shape
2 - Ajouter à la classe shape les fonctions virtual Area et Perimeter
- Area retournant l'air de la shape.
- Perimeter retournant le perimetre de la shape.

Ici il n'y a pas de corps de fonction, et donc elles retournent toutes les deux 0;

3 - Definir les trois classes Square, Rectangle et Circle
4 - Les faire toutes hériter de la classe Shape.
5 - Ajouter les propriétés nécessaires à chaque classe
- Square : width
- Rectangle : width et heigth
- Circle : radius

6 - Implementer dans chaque classe les methodes Area et Perimeter.
7 - Surcharger et Implementer les fonctions ToString de chaque classe.

8 - Ajouter aux classes Rectangle et Square la fonction Diagonal qui retourne la valeur de la diagonale de la forme.
9- Ajouter à la class Circle la fonction Diameter qui retourne la valeur du diametre;

10 - Creer un tableau de shape en l'initialisant avec des instances des trois classes filles
11 - Creer une boucle pour parcourir tout le tableau et Appeller les differentes méthodes pour chaque instance.

12 - Dans la boucle tester si les instances sont de type Square ou Rectangle avec le mot clefs 'is'
 => si oui appeler la fonction Diagonal et afficher le resultat.

13 - Dans la boucle tester si les instances sont de type Circlea avec le mot clefs 'is'
 => si oui appeler la fonction Diameter et afficher le resultat

*/
namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(4.5f);
            Square square1 = new Square(6);
            Rectangle rectangle1 = new Rectangle(3.5f, 6.2f);

            Shape[] shapes = new Shape[] { circle1, square1, rectangle1, new Hexagon() };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i] + $" de périmetre {shapes[i].Perimeter()} et d'aire {shapes[i].Area()}");

                if(shapes[i] is Circle)
                {
                    Circle tmpCircle = (Circle)shapes[i];
                    Console.WriteLine(shapes[i] + $" de diametre {tmpCircle.Diameter()}");
                }
                else if(shapes[i] is Rectangle)
                {
                    Rectangle tmpRectangle = (Rectangle)shapes[i];
                    Console.WriteLine(shapes[i] + $" de diagonale {tmpRectangle.Diagonal()}");
                }
                else if(shapes[i] is Square)
                {
                    Square tmpSquare = (Square)shapes[i];
                    Console.WriteLine(shapes[i] + $" de diagonale {tmpSquare.Diagonal()}");
                }
                Console.WriteLine(shapes[i].DisplayShape());
            }

        }
    }
}
