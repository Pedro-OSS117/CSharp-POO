namespace Exo1
{
    public class CompteSurCarnet : Account
    {
        private int _numberCarnet; 

        public int NumberCarnet
        {
            get { return _numberCarnet; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _numberCarnet = value;
            }
        }        

        public CompteSurCarnet() : base()
        {
            NumberCarnet = 0;
        }

        public CompteSurCarnet(int number, string nameOwner, float solde, int numberCarnet) : base(number, nameOwner, solde)
        {
            NumberCarnet = numberCarnet;
        }
    }
}