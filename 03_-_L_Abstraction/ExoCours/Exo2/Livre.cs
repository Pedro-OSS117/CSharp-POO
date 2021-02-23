namespace Exo2
{
    public abstract class Livre : Document
    {
        private string _auhtor;

        private int _numberPages;

        public Livre(int registerNumber, string title, string author, int numberPages) : base(registerNumber, title)
        {
            _auhtor = author;
            _numberPages = numberPages;
        }
    }
}