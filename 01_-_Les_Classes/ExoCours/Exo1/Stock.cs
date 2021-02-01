using System;

namespace Exo1
{
    public class Stock
    {
        private Article[] _articles;

        public Stock()
        {
            _articles = new Article[1];
        }

        public void AddArticle(Article newArticle)
        {
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i] == null)
                {
                    _articles[i] = newArticle;
                    return;
                }
            }

            Article[] newArticles = new Article[_articles.Length + 1];
            for (int i = 0; i < _articles.Length; i++)
            {
                newArticles[i] = _articles[i];
            }
            newArticles[_articles.Length] = newArticle;
            _articles = newArticles;
        }

        public void RemoveArticle(Article removedArticle)
        {
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i] == removedArticle)
                {
                    _articles[i] = null;
                    return;
                }
            }
        }

        public void DisplayAllArticles()
        {
            string allArticles = "Tous les articles dans le stock :\n";
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i] != null)
                {
                    allArticles += _articles[i] + "\n";
                }
                else
                {
                    allArticles += "EMPTY : Pas d'article à cet emplacement \n";
                }
            }
            Console.WriteLine(allArticles);
        }

        public bool IsInStock(Article article)
        {
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i] == article)
                {
                    return true;
                }
            }
            return false;
        }

        public Article FindArticle(int numRefSearched)
        {
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i] != null && _articles[i].GetRefNum() == numRefSearched)
                {
                    return _articles[i];
                }
            }
            return null;
        }

        public void DisplayAllArticlesUpBuyPrice(float sellingPriceTested)
        {
            Console.WriteLine("Tous les articles plus cher que " + sellingPriceTested + " euros : ");
            string allArticles = "";
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i] != null && _articles[i].GetSellingPrice() > sellingPriceTested)
                {
                    allArticles += _articles[i] + "\n";
                }
            }
            if (string.IsNullOrEmpty(allArticles))
            {
                allArticles = "Pas de produit superieur à " + sellingPriceTested + " euros !";
            }
            Console.WriteLine(allArticles);
        }

        public void ModifyArticleSellingPrice(int numRefArticleToModify, float newSellingPrice)
        {
            Article article = FindArticle(numRefArticleToModify);
            if(article != null)
            {
                article.SetSellingPrice(newSellingPrice);
            }
        }
    }
}