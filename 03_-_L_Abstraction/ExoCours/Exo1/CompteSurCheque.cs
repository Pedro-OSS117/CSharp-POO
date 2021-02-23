namespace Exo1
{
    public class CompteSurCheque : Account
    {
        protected int _numeroCheque;
        protected int _numeroCarte;
        protected int _dateFinValidite;        

        public int NumberCheque
        {
            get { return _numeroCheque; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _numeroCheque = value;
            }
        }

        public int NumberCarte
        {
            get { return _numeroCarte; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _numeroCarte = value;
            }
        }

        public CompteSurCheque() : base()
        {
            _numeroCheque = 0;
            _numeroCarte = 0;
            _dateFinValidite = 0;
        }

        public CompteSurCheque(int number, string nameOwner, float solde, int numeroCheque, int numeroCarte, int dateFinValidite) : base(number, nameOwner, solde)
        {
            _numeroCheque = numeroCheque;
            _numeroCarte = numeroCarte;
            _dateFinValidite = dateFinValidite;
        }
    }
}