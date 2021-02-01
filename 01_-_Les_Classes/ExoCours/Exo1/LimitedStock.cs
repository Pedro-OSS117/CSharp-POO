namespace Exo1
{
    public class LimitedStock
    {
        private Article[] _articles;

        public LimitedStock(int nbrArticles)
        {
            _articles = new Article[nbrArticles];
        }

        public bool AddArticle(Article newArticle)
        {
            for (int i = 0; i < _articles.Length; i++)
            {
                if(_articles[i] == null)
                {
                    _articles[i] = newArticle;
                    return true;
                }
            }
            return false;
        }
    }
}