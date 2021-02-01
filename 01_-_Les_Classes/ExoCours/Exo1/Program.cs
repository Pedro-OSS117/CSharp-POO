using System;

/** Gestion de stock

Soit à développer une application pour la gestion de stock. 
Un article est caractérisé par son numéro de référence, son nom, son prix d’achat et son prix de vente.

1) Créer la classe Article.

2) Ajouter un constructeur à la classe Article.

3) Définir une méthode qui retourne une chaine de caractères représentant les différents attributs de l’objet Article. 

Pour gérer le stock du magasin, ce dernier se caractérise par son stock d’articles. 
Le stock est représenté par une collection d’objets Article.

4) Ecrire la classe Stock qui permet de réaliser les fonctionnalités suivantes :
    a. Ajouter un nouvel Article.
    b. Afficher tous les Articles du magasin.
    c. Rechercher un Article.
    d. Afficher les Articles dont les prix d’achat est supérieur à une valeur saisie.
    e. Supprimer un Article.
    f. Modifier un Article.

5) Utiliser les deux classes dans main pour en faire un exemple de programme de stockage
**/

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) et 2)
            Article a = new Article(404, "cigarette", 1.5f, 450f);
            Article a1 = new Article(52, "viande", 10.50f, 150);
            Article a2 = new Article(325, "gruyere", 54.5f, 98f);

            // 3)
            Stock stock = new Stock();

            // 4) a)
            stock.AddArticle(a);
            stock.AddArticle(a1);
            stock.AddArticle(a2);

            // 4) b)
            stock.DisplayAllArticles();

            if(!stock.IsInStock(a))
            {
                Console.WriteLine($"{a} n'est pas dans le stock !");
            }

            // 4) c)
            Article searchedArticle = stock.FindArticle(404);
            if(searchedArticle != null)
            {
                Console.WriteLine($"{searchedArticle} est pas dans le stock !");
            }

            // 4) d) 
            stock.DisplayAllArticlesUpBuyPrice(1000);

            // 4) f)            
            stock.DisplayAllArticles();
            stock.RemoveArticle(a);
            stock.DisplayAllArticles();
            
            stock.FindArticle(151515);
            stock.ModifyArticleSellingPrice(325, 1500);
            stock.DisplayAllArticles();

        }
    }
}
