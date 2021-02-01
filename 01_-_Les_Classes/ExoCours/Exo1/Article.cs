namespace Exo1
{
    public class Article
    {
        private int _numRef;
        private string _name;
        private float _buyPrice;
        private float _sellingPrice;

        public Article(int numRef, string name, float buyPrice, float sellingPrice)
        {
            // Prop numero de ref
            if(numRef < 0)
            {
                numRef = 0;
            }
            _numRef = numRef;

            // Prop name 
            if(string.IsNullOrEmpty(name))
            {
                name = "NAME NOT VALID";
            }
            _name = name;

            // Prop buy price
            if(buyPrice <= 0)
            {
                buyPrice = 0.1f;
            }
            _buyPrice = buyPrice;

            // Prop selling price
            if(sellingPrice < _buyPrice)
            {
                sellingPrice = _buyPrice;
            }
            _sellingPrice = sellingPrice;
        }

        public override string ToString()
        {
            return $"Article numero de ref : {_numRef}, nom : {_name}, prix d'achat : {_buyPrice}, prix de vente {_sellingPrice}.";
        }

    }
}